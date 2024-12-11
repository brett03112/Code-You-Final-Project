using System;
using HolidayDessertStore.Data;
using HolidayDessertStore.Models;
using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace HolidayDessertStore.Pages.DessertShop
{
    public class DessertShopModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IShoppingCartService _cartService;

        /// <summary>
        /// Constructor for DessertShopModel, which provides a Razor Page for users to browse the holiday desserts.
        /// </summary>
        /// <param name="context">The database context.</param>
        /// <param name="cartService">The IShoppingCartService to use for adding items to the cart.</param>
        public DessertShopModel(ApplicationDbContext context, IShoppingCartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        public IList<Dessert> Desserts { get; set; } = new List<Dessert>();
        [TempData]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// OnGetAsync is a Razor Page handler that is called when the page is requested.
        /// It retrieves a list of all desserts from the database, and assigns it to the Desserts property.
        /// </summary>
        public async Task OnGetAsync()
        {
            Desserts = await _context.Desserts.ToListAsync();
        }

        /// <summary>
        /// OnPostAddToCartAsync is a Razor Page handler that is called when a user clicks the "Add to Cart" button on a dessert.
        /// It adds the specified quantity of the dessert to the cart, and redirects to the same page with a status message.
        /// </summary>
        /// <param name="dessertId">The ID of the dessert to add to the cart.</param>
        /// <param name="quantity">The quantity of the dessert to add to the cart.</param>
        /// <returns>A redirect to the same page with a status message.</returns>
        public async Task<IActionResult> OnPostAddToCartAsync(int dessertId, int quantity)
        {
            if (quantity <= 0)
            {
                StatusMessage = "Please select a valid quantity.";
                return RedirectToPage();
            }

            var cartId = HttpContext.Session.GetString("CartId");
            if (string.IsNullOrEmpty(cartId))
            {
                cartId = Guid.NewGuid().ToString();
                HttpContext.Session.SetString("CartId", cartId);
            }

            try
            {
                await _cartService.AddToCartAsync(dessertId, cartId, quantity);
                StatusMessage = "Item added to cart successfully!";
            }
            catch (InvalidOperationException ex)
            {
                StatusMessage = ex.Message;
            }
            catch (Exception)
            {
                StatusMessage = "Error adding item to cart.";
            }
            
            return RedirectToPage();
        }
    }
}
