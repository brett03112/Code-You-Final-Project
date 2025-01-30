using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolidayDessertStore.Services;

namespace HolidayDessertStore.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly WeatherService _weatherService;

    public WeatherForecast? WeatherData { get; set; }

        /// <summary>
        /// Constructor for IndexModel, which is the Razor Page Model for the Index page.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger{IndexModel}"/> instance used to write log messages.</param>
        /// <param name="weatherService">The <see cref="WeatherService"/> instance used to fetch the weather forecast data.</param>
    public IndexModel(ILogger<IndexModel> logger, WeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

        /// <summary>
        /// OnGetAsync is a Razor Page handler that is called when the page is requested.
        /// It fetches the weather forecast data from the <see cref="WeatherService"/> and stores it in the <see cref="WeatherData"/> property.
        /// If an error occurs while fetching the data, it logs the exception with the <see cref="ILogger{IndexModel}"/>.</summary>
    public async Task OnGetAsync()
    {
        try
        {
            WeatherData = await _weatherService.GetWeatherForecastAsync();
            if (WeatherData == null)
            {
                _logger.LogWarning("Weather data is null");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching weather data");
        }
    }
}
