
using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolidayDessertStore.Pages.Checkout
{
    public class SuccessModel : PageModel
    {
        private readonly IShoppingCartService _cartService;

        /// <summary>
        /// Constructor for SuccessModel, which is used to initialize an instance of Checkout.SuccessModel.
        /// </summary>
        /// <param name="cartService">The <see cref="IShoppingCartService"/> instance used to access the contents of the user's cart.</param>
        public SuccessModel(IShoppingCartService cartService)
        {
            _cartService = cartService;
        }

        /// <summary>
        /// OnGetAsync is a Razor Page handler that is called when the page is requested.
        /// It clears the cart after a successful checkout.
        /// </summary>
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
