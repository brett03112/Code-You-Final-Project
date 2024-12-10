using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe.Checkout;

namespace HolidayDessertStore.Pages.Checkout
{
    public class IndexModel : PageModel
    {
        private readonly IShoppingCartService _cartService;
        private readonly IConfiguration _configuration;

        public IndexModel(IShoppingCartService cartService, IConfiguration configuration)
        {
            _cartService = cartService;
            _configuration = configuration;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var cartId = HttpContext.Session.GetString("CartId");
            if (string.IsNullOrEmpty(cartId))
            {
                return RedirectToPage("/Cart/Index");
            }

            var cartItems = await _cartService.GetCartItemsAsync(cartId);
            if (!cartItems.Any())
            {
                return RedirectToPage("/Cart/Index");
            }

            var domain = $"{Request.Scheme}://{Request.Host}";
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = cartItems.Select(item => new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(item.Price * 100), // Convert to cents
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Dessert.Name,
                            Description = item.Dessert.Description,
                            Images = new List<string> { $"{domain}{item.Dessert.ImagePath}" }
                        }
                    },
                    Quantity = item.Quantity
                }).ToList(),
                Mode = "payment",
                SuccessUrl = $"{domain}/Checkout/Success",
                CancelUrl = $"{domain}/Cart"
            };

            var service = new SessionService();
            var session = await service.CreateAsync(options);

            return new JsonResult(new { id = session.Id });
        }
    }
}
