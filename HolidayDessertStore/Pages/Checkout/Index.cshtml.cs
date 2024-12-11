using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe;
using Stripe.Checkout;

namespace HolidayDessertStore.Pages.Checkout
{
    public class IndexModel : PageModel
    {
        private readonly IShoppingCartService _cartService;
        private readonly IConfiguration _configuration;
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _environment;

        /// <summary>
        /// Constructor for IndexModel, which is used to initialize an instance of Checkout.IndexModel.
        /// </summary>
        /// <param name="cartService">The <see cref="IShoppingCartService"/> instance used to access the contents of the user's cart.</param>
        /// <param name="configuration">The <see cref="IConfiguration"/> instance containing configuration data.</param>
        /// <param name="logger">The <see cref="ILogger{IndexModel}"/> instance used to write log messages.</param>
        /// <param name="environment">The <see cref="IWebHostEnvironment"/> instance containing information about the hosting environment.</param>
        public IndexModel(IShoppingCartService cartService, IConfiguration configuration, ILogger<IndexModel> logger, IWebHostEnvironment environment)
        {
            _cartService = cartService;
            _configuration = configuration;
            _logger = logger;
            _environment = environment;
        }

        /// <summary>
        /// Handles the GET request for the checkout page.
        /// </summary>
        /// <returns>
        /// An <see cref="IActionResult"/> containing the JSON response.
        /// </returns>
        /// <remarks>
        /// This method is called when the user navigates to the checkout page.
        /// It returns a JSON response that contains the ID of the Stripe session.
        /// </remarks>
        public async Task<IActionResult> OnGetAsync()
        {
            if (!Request.Headers.Accept.Contains("application/json"))
            {
                return Page();
            }

            try
            {
                var cartId = HttpContext.Session.GetString("CartId");
                if (string.IsNullOrEmpty(cartId))
                {
                    return new JsonResult(new { error = "No cart found" }) { StatusCode = 400 };
                }

                var cartItems = await _cartService.GetCartItemsAsync(cartId);
                if (!cartItems.Any())
                {
                    return new JsonResult(new { error = "Cart is empty" }) { StatusCode = 400 };
                }

                var domain = $"{Request.Scheme}://{Request.Host}";
                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string> { "card" },
                    LineItems = cartItems.Select(item =>
                    {
                        var lineItem = new SessionLineItemOptions
                        {
                            PriceData = new SessionLineItemPriceDataOptions
                            {
                                UnitAmount = (long)(item.Price * 100), // Convert to cents
                                Currency = "usd",
                                ProductData = new SessionLineItemPriceDataProductDataOptions
                                {
                                    Name = item.Dessert.Name,
                                    Description = item.Dessert.Description,
                                }
                            },
                            Quantity = item.Quantity
                        };

                        // Only include images if we're not in development environment
                        if (!_environment.IsDevelopment())
                        {
                            var imageUrl = $"{domain}/images/desserts/{System.IO.Path.GetFileName(item.Dessert.ImagePath)}";
                            _logger.LogInformation($"Creating line item for {item.Dessert.Name} with image URL: {imageUrl}");
                            lineItem.PriceData.ProductData.Images = new List<string> { imageUrl };
                        }

                        return lineItem;
                    }).ToList(),
                    Mode = "payment",
                    SuccessUrl = $"{domain}/Checkout/Success",
                    CancelUrl = $"{domain}/Cart",
                    CustomerEmail = User.Identity?.IsAuthenticated == true ? User.Identity.Name : null,
                    PaymentIntentData = new SessionPaymentIntentDataOptions
                    {
                        CaptureMethod = "automatic"
                    }
                };

                var service = new SessionService();
                var session = await service.CreateAsync(options);

                return new JsonResult(new { id = session.Id });
            }
            catch (StripeException e)
            {
                _logger.LogError($"Stripe error: {e.Message}");
                return new JsonResult(new { error = e.Message }) { StatusCode = 400 };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Checkout error: {ex.Message}");
                return new JsonResult(new { error = "An error occurred while processing your request." }) { StatusCode = 500 };
            }
        }
    }
}
