using System;
using HolidayDessertStore.Models;
using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace HolidayDessertStore.Pages.Cart
{
    public class IndexModel : PageModel
    {
        private readonly IShoppingCartService _cartService;

        /// <summary>
        /// Constructor for IndexModel, which is used to initialize an instance of Cart.IndexModel.
        /// </summary>
        /// <param name="cartService">The <see cref="IShoppingCartService"/> instance used to access the contents of the user's cart.</param>
        public IndexModel(IShoppingCartService cartService)
        {
            _cartService = cartService;
        }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public decimal CartTotal { get; set; }
        [TempData]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Handles the GET request for the cart page.
        /// </summary>
        /// <remarks>
        /// This method is called when the user navigates to the cart page.
        /// It retrieves the list of cart items and the total cost from the database and stores them in the <see cref="CartItems"/> and <see cref="CartTotal"/> properties.
        /// </remarks>
        public async Task OnGetAsync()
        {
            var cartId = GetOrCreateCartId();
            CartItems = await _cartService.GetCartItemsAsync(cartId);
            CartTotal = await _cartService.GetCartTotalAsync(cartId);
        }

        /// <summary>
        /// Handles the POST request for updating the quantity of a cart item.
        /// </summary>
        /// <param name="id">The ID of the cart item to be updated.</param>
        /// <param name="quantity">The new quantity of the cart item.</param>
        /// <returns>A redirect to the same page with a status message.</returns>
        /// <remarks>
        /// This method is called when the user clicks the "Update" button next to an item in the cart.
        /// It updates the quantity of the item in the cart and redirects back to the same page with a status message.
        /// If the requested quantity exceeds the available stock, an error message is displayed.
        /// </remarks>
        public async Task<IActionResult> OnPostUpdateQuantityAsync(int id, int quantity)
        {
            try
            {
                await _cartService.UpdateCartItemQuantityAsync(id, quantity);
                StatusMessage = "Cart updated successfully";
            }
            catch (InvalidOperationException ex)
            {
                StatusMessage = ex.Message;
            }
            catch (Exception)
            {
                StatusMessage = "An error occurred while updating the cart";
            }
            return RedirectToPage();
        }

        /// <summary>
        /// Handles the POST request for checkout.
        /// </summary>
        /// <returns>A redirect to the checkout page if there are items in the cart, otherwise a redirect to the same page.</returns>
        /// <remarks>
        /// This method is called when the user clicks the "Checkout" button on the cart page.
        /// If there are items in the cart, it redirects to the checkout page.
        /// If there are no items in the cart, it redirects back to the same page.
        /// </remarks>
        public async Task<IActionResult> OnPostCheckoutAsync()
        {
            var cartId = GetOrCreateCartId();
            var cartItems = await _cartService.GetCartItemsAsync(cartId);
            if (!cartItems.Any())
            {
                return RedirectToPage();
            }

            return RedirectToPage("/Checkout/Index");
        }

        
        /// <summary>
        /// Retrieves or creates a cart ID from the user's session.
        /// </summary>
        /// <returns>The cart ID as a string.</returns>
        /// <remarks>
        /// This method is called when the user navigates to the cart page.
        /// It retrieves the cart ID from the session if it exists, otherwise it generates a new cart ID and stores it in the session.
        /// </remarks>
        private string GetOrCreateCartId()
        {
            if (HttpContext.Session == null)
            {
                throw new InvalidOperationException("Session is not available");
            }

            var cartId = HttpContext.Session.GetString("CartId");
            if (string.IsNullOrEmpty(cartId))
            {
                cartId = Guid.NewGuid().ToString();
                HttpContext.Session.SetString("CartId", cartId);
            }
            return cartId;
        }
    }
}
