using HolidayDessertStore.Data;
using HolidayDessertStore.Models;
using Microsoft.EntityFrameworkCore;

namespace HolidayDessertStore.Services
{
    public interface IShoppingCartService
    {
        Task<CartItem> AddToCartAsync(int dessertId, string cartId);
        Task<List<CartItem>> GetCartItemsAsync(string cartId);
        Task<decimal> GetCartTotalAsync(string cartId);
        Task RemoveFromCartAsync(int cartItemId);
        Task ClearCartAsync(string cartId);
    }

    public class ShoppingCartService : IShoppingCartService
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CartItem> AddToCartAsync(int dessertId, string cartId)
        {
            var dessert = await _context.Desserts.FindAsync(dessertId);
            if (dessert == null) throw new ArgumentException("Dessert not found");

            var existingItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.CartId == cartId && c.DessertId == dessertId);

            if (existingItem != null)
            {
                existingItem.Quantity++;
                await _context.SaveChangesAsync();
                return existingItem;
            }

            var cartItem = new CartItem
            {
                CartId = cartId,
                DessertId = dessertId,
                Quantity = 1,
                Price = dessert.Price
            };

            _context.CartItems.Add(cartItem);
            await _context.SaveChangesAsync();
            return cartItem;
        }

        public async Task<List<CartItem>> GetCartItemsAsync(string cartId)
        {
            return await _context.CartItems
                .Include(c => c.Dessert)
                .Where(c => c.CartId == cartId)
                .ToListAsync();
        }

        public async Task<decimal> GetCartTotalAsync(string cartId)
        {
            return await _context.CartItems
                .Where(c => c.CartId == cartId)
                .SumAsync(c => c.Price * c.Quantity);
        }

        public async Task RemoveFromCartAsync(int cartItemId)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task ClearCartAsync(string cartId)
        {
            var cartItems = await _context.CartItems
                .Where(c => c.CartId == cartId)
                .ToListAsync();

            _context.CartItems.RemoveRange(cartItems);
            await _context.SaveChangesAsync();
        }
    }
}
