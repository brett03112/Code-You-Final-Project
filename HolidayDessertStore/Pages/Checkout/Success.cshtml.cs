
using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolidayDessertStore.Pages.Checkout
{
    public class SuccessModel : PageModel
    {
        private readonly IShoppingCartService _cartService;

        public SuccessModel(IShoppingCartService cartService)
        {
            _cartService = cartService;
        }

        public async Task OnGetAsync()
        {
            // Clear the cart after successful checkout
            var cartId = HttpContext.Session.GetString("CartId");
            if (!string.IsNullOrEmpty(cartId))
            {
                await _cartService.ClearCartAsync(cartId);
                HttpContext.Session.Remove("CartId");
            }
        }
    }
}
