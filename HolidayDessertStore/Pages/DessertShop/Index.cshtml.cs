using HolidayDessertStore.Data;
using HolidayDessertStore.Models;
using HolidayDessertStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HolidayDessertStore.Pages.DessertShop
{
    public class DessertShopModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IShoppingCartService _cartService;

        public DessertShopModel(ApplicationDbContext context, IShoppingCartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        public IList<Dessert> Desserts { get; set; }
        [TempData]
        public string StatusMessage { get; set; }

        public async Task OnGetAsync()
        {
            Desserts = await _context.Desserts.ToListAsync();
        }

        public async Task<IActionResult> OnPostAddToCartAsync(int dessertId)
        {
            var cartId = HttpContext.Session.GetString("CartId");
            if (string.IsNullOrEmpty(cartId))
            {
                cartId = Guid.NewGuid().ToString();
                HttpContext.Session.SetString("CartId", cartId);
            }

            try
            {
                await _cartService.AddToCartAsync(dessertId, cartId);
                StatusMessage = "Item added to cart successfully!";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                StatusMessage = "Error adding item to cart.";
                return RedirectToPage();
            }
        }
    }
}
