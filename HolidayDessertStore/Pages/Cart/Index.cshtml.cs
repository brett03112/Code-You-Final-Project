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
        /// Constructor for IndexModel, which provides a Razor Page for users to view and edit their shopping cart.
        /// </summary>
        /// <param name="cartService">The IShoppingCartService to use for getting and editing the cart.</param>
        public IndexModel(IShoppingCartService cartService)
        {
            _cartService = cartService;
        }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public decimal CartTotal { get; set; }
        [TempData]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// OnGetAsync is a Razor Page handler that is called when the page is requested.
        /// It retrieves the cart ID from the session, gets the items in the cart,
        /// and calculates the total cost of the items in the cart.
        /// </summary>
        public async Task OnGetAsync()
        {
            var cartId = GetOrCreateCartId();
            CartItems = await _cartService.GetCartItemsAsync(cartId);
            CartTotal = await _cartService.GetCartTotalAsync(cartId);
        }

        /// <summary>
        /// OnPostRemoveAsync is a Razor Page handler that is called when the "Remove" button is clicked on a cart item.
        /// It removes the specified cart item from the cart, and redirects to the same page.
        /// </summary>
        /// <param name="id">The ID of the cart item to be removed.</param>
        public async Task<IActionResult> OnPostRemoveAsync(int id)
        {
            await _cartService.RemoveFromCartAsync(id);
            return RedirectToPage();
        }

        /// <summary>
        /// OnPostUpdateQuantityAsync is a Razor Page handler that is called when the "Update Quantity" button is clicked on a cart item.
        /// It updates the quantity of the specified cart item, and redirects to the same page.
        /// </summary>
        /// <param name="id">The ID of the cart item to be updated.</param>
        /// <param name="quantity">The new quantity of the cart item.</param>
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
        /// OnPostCheckoutAsync is a Razor Page handler that is called when the "Checkout" button is clicked.
        /// It retrieves the cart ID from the session, gets the items in the cart,
        /// and redirects to the Stripe checkout page if there are any items in the cart.
        /// </summary>
        public async Task<IActionResult> OnPostCheckoutAsync()
        {
            var cartId = GetOrCreateCartId();
            var cartItems = await _cartService.GetCartItemsAsync(cartId);
            if (!cartItems.Any())
            {
                return RedirectToPage();
            }

            // Redirect to Stripe checkout
            return RedirectToPage("/Checkout/Index");
        }

        /// <summary>
        /// Retrieves the cart ID from the session, or creates a new one if it does not exist.
        /// </summary>
        /// <returns>The cart ID.</returns>
        private string GetOrCreateCartId()
        {
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
