using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace HolidayDessertStore.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class DessertManagementModel : PageModel
    {
        public void OnGet()
        {
            // Page load logic can be added here if needed
        }
    }
}
