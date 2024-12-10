using HolidayDessertStore.Models;
using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolidayDessertStore.Pages.Cart
{
    public class IndexModel : PageModel
    {
        private readonly IShoppingCartService _cartService;

        public IndexModel(IShoppingCartService cartService)
        {
            _cartService = cartService;
        }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public decimal CartTotal { get; set; }

        public async Task OnGetAsync()
        {
            var cartId = GetOrCreateCartId();
            CartItems = await _cartService.GetCartItemsAsync(cartId);
            CartTotal = await _cartService.GetCartTotalAsync(cartId);
        }

        public async Task<IActionResult> OnPostRemoveAsync(int id)
        {
            await _cartService.RemoveFromCartAsync(id);
            return RedirectToPage();
        }

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