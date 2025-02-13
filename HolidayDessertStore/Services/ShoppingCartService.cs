using HolidayDessertStore.Data;
using HolidayDessertStore.Models;
using Microsoft.EntityFrameworkCore;

namespace HolidayDessertStore.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly ApplicationDbContext _context;
        private readonly IDessertApiService _dessertApiService;

        public ShoppingCartService(ApplicationDbContext context, IDessertApiService dessertApiService)
        {
            _context = context;
            _dessertApiService = dessertApiService;
        }

        /// <summary>
        /// Adds the specified quantity of a dessert to a cart.
        /// </summary>
        /// <param name="dessertId">The ID of the dessert to add.</param>
        /// <param name="cartId">The ID of the cart.</param>
        /// <param name="quantity">The quantity of the dessert to add.</param>
        /// <returns>The updated cart item.</returns>
        /// <exception cref="ArgumentException">The dessert with the specified ID does not exist.</exception>
        /// <exception cref="InvalidOperationException">The requested quantity exceeds the available stock.</exception>
        public async Task<CartItem> AddToCartAsync(int dessertId, string cartId, int quantity)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var dessert = await _dessertApiService.GetDessertByIdAsync(dessertId);
                if (dessert == null) throw new ArgumentException("Dessert not found");
                
                // Check if requested quantity is available
                if (quantity > dessert.Quantity)
                    throw new InvalidOperationException($"Only {dessert.Quantity} items available");

                var existingItem = await _context.CartItems
                    .FirstOrDefaultAsync(c => c.CartId == cartId && c.DessertId == dessertId);

                if (existingItem != null)
                {
                    // Check if total quantity after adding would exceed available stock
                    if ((existingItem.Quantity + quantity) > dessert.Quantity)
                        throw new InvalidOperationException($"Cannot add {quantity} more items. Only {dessert.Quantity - existingItem.Quantity} items available");

                    existingItem.Quantity += quantity;
                    await _context.SaveChangesAsync();

                    // Update dessert quantity through API
                    dessert.Quantity -= quantity;
                    await _dessertApiService.UpdateDessertAsync(dessert.Id, dessert);

                    await transaction.CommitAsync();
                    return existingItem;
                }

                var cartItem = new CartItem
                {
                    CartId = cartId,
                    DessertId = dessertId,
                    Quantity = quantity,
                    Price = dessert.Price,
                    Dessert = dessert
                };

                // Update dessert quantity through API
                dessert.Quantity -= quantity;
                await _dessertApiService.UpdateDessertAsync(dessert.Id, dessert);

                _context.CartItems.Add(cartItem);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return cartItem;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        /// <summary>
        /// Retrieves a list of all cart items in a given cart.
        /// </summary>
        /// <param name="cartId">The ID of the cart.</param>
        /// <returns>A list of cart items.</returns>
        public async Task<List<CartItem>> GetCartItemsAsync(string cartId)
        {
            var cartItems = await _context.CartItems
                .Where(c => c.CartId == cartId)
                .ToListAsync();

            // Load dessert details from API for each cart item
            foreach (var item in cartItems)
            {
                item.Dessert = await _dessertApiService.GetDessertByIdAsync(item.DessertId);
            }

            return cartItems;
        }

        /// <summary>
        /// Calculates the total cost of all items in a given cart.
        /// </summary>
        /// <param name="cartId">The ID of the cart.</param>
        /// <returns>The total cost of all items in the cart.</returns>
        public async Task<decimal> GetCartTotalAsync(string cartId)
        {
            return await _context.CartItems
                .Where(c => c.CartId == cartId)
                .SumAsync(c => c.Price * c.Quantity);
        }

        /// <summary>
        /// Removes the specified cart item from the cart, and updates the quantity of the associated dessert.
        /// </summary>
        /// <param name="cartItemId">The ID of the cart item to be removed.</param>
        public async Task RemoveFromCartAsync(int cartItemId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var cartItem = await _context.CartItems
                    .FirstOrDefaultAsync(c => c.Id == cartItemId);

                if (cartItem != null)
                {
                    // Get dessert from API and update quantity
                    var dessert = await _dessertApiService.GetDessertByIdAsync(cartItem.DessertId);
                    if (dessert != null)
                    {
                        dessert.Quantity += cartItem.Quantity;
                        await _dessertApiService.UpdateDessertAsync(dessert.Id, dessert);
                    }

                    _context.CartItems.Remove(cartItem);
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        /// <summary>
        /// Clears a cart by removing all items and restoring their quantities back to the associated desserts.
        /// </summary>
        /// <param name="cartId">The ID of the cart to be cleared.</param>
        public async Task ClearCartAsync(string cartId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var cartItems = await _context.CartItems
                    .Where(c => c.CartId == cartId)
                    .ToListAsync();

                foreach (var item in cartItems)
                {
                    // Get dessert from API and update quantity
                    var dessert = await _dessertApiService.GetDessertByIdAsync(item.DessertId);
                    if (dessert != null)
                    {
                        dessert.Quantity += item.Quantity;
                        await _dessertApiService.UpdateDessertAsync(dessert.Id, dessert);
                    }
                }

                _context.CartItems.RemoveRange(cartItems);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        /// <summary>
        /// Updates the quantity of a cart item, and updates the quantity of the associated dessert accordingly.
        /// </summary>
        /// <param name="cartItemId">The ID of the cart item to be updated.</param>
        /// <param name="quantity">The new quantity of the cart item.</param>
        /// <exception cref="ArgumentException">The cart item with the specified ID does not exist.</exception>
        /// <exception cref="InvalidOperationException">The requested quantity exceeds the available stock.</exception>
        public async Task UpdateCartItemQuantityAsync(int cartItemId, int quantity)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var cartItem = await _context.CartItems
                    .FirstOrDefaultAsync(c => c.Id == cartItemId);

                if (cartItem == null)
                    throw new ArgumentException("Cart item not found");

                // Get dessert from API
                var dessert = await _dessertApiService.GetDessertByIdAsync(cartItem.DessertId);
                if (dessert == null)
                    throw new ArgumentException("Dessert not found");

                // Calculate available quantity (current dessert quantity + current cart item quantity)
                var totalAvailable = dessert.Quantity + cartItem.Quantity;

                if (quantity > totalAvailable)
                    throw new InvalidOperationException($"Only {totalAvailable} items available");

                if (quantity <= 0)
                {
                    // If quantity is 0 or negative, remove item and restore quantity
                    dessert.Quantity += cartItem.Quantity;
                    await _dessertApiService.UpdateDessertAsync(dessert.Id, dessert);
                    _context.CartItems.Remove(cartItem);
                }
                else
                {
                    // Update dessert quantity based on the difference
                    var quantityDifference = cartItem.Quantity - quantity;
                    dessert.Quantity += quantityDifference;
                    await _dessertApiService.UpdateDessertAsync(dessert.Id, dessert);
                    cartItem.Quantity = quantity;
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        /// <summary>
        /// Gets the available quantity of a dessert.
        /// </summary>
        /// <param name="dessertId">The ID of the dessert.</param>
        /// <returns>The available quantity.</returns>
        /// <exception cref="ArgumentException">Dessert not found.</exception>
        public async Task<int> GetAvailableQuantityAsync(int dessertId)
        {
            var dessert = await _dessertApiService.GetDessertByIdAsync(dessertId);
            if (dessert == null) throw new ArgumentException("Dessert not found");
            return dessert.Quantity;
        }
    }
}
