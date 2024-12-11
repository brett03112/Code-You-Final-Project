using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolidayDessertStore.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    /// <summary>
    /// Constructor for PrivacyModel. This takes a logger as an argument.
    /// </summary>
    /// <param name="logger">An ILogger for logging errors.</param>
    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// OnGet is a Razor Page handler that is called when the page is requested.
    /// </summary>
    public void OnGet()
    {
    }
}

