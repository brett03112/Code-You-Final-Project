using HolidayDessertStore.Data;
using HolidayDessertStore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HolidayDessertStore.Pages.DessertShop
{
    public class DessertShopModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DessertShopModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dessert> Desserts { get; set; }

        public async Task OnGetAsync()
        {
            Desserts = await _context.Desserts.ToListAsync();
        }
    }
}