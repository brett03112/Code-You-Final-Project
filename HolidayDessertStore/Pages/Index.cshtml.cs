using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolidayDessertStore.Services;

namespace HolidayDessertStore.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly WeatherService _weatherService;

    public WeatherForecast WeatherData { get; set; }

    public IndexModel(ILogger<IndexModel> logger, WeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    public async Task OnGetAsync()
    {
        try
        {
            WeatherData = await _weatherService.GetWeatherForecastAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching weather data");
        }
    }
}
