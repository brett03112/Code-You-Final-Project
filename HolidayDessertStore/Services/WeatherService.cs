using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace HolidayDessertStore.Services;

public class WeatherForecast
{
    public Current Current { get; set; } = null!;
    public Forecast Forecast { get; set; } = null!;
}

public class Current
{
    public double Temp_f { get; set; }
    public WeatherCondition Condition { get; set; } = null!;
}

public class WeatherCondition
{
    public string Text { get; set; } = string.Empty;
}

public class Forecast
{
    public List<ForecastDay> Forecastday { get; set; } = new List<ForecastDay>();
}

public class ForecastDay
{
    public Day Day { get; set; } = null!;
    public string Date { get; set; } = string.Empty;
}

public class Day
{
    public double Maxtemp_f { get; set; }
    public double Mintemp_f { get; set; }
    public WeatherCondition Condition { get; set; } = null!;
}

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly ILogger<WeatherService> _logger;

    public WeatherService(IHttpClientFactory httpClientFactory, ILogger<WeatherService> logger)
    {
        _httpClient = httpClientFactory.CreateClient();
        _apiKey = "227bd413254a491885a101922240512";
        _logger = logger;
    }

    public async Task<WeatherForecast?> GetWeatherForecastAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync(
                $"http://api.weatherapi.com/v1/forecast.json?key={_apiKey}&q=8305 KY-1781, Crab Orchard, KY 40419&days=4&aqi=no");
            
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            // Log the response content
            _logger.LogInformation("Weather API Response: {Content}", content);

            var weatherData = JsonSerializer.Deserialize<WeatherForecast>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            // Ensure we have valid data
            if (weatherData?.Current?.Condition == null || weatherData.Forecast?.Forecastday == null)
            {
                _logger.LogWarning("Weather data is incomplete");
                return null;
            }

            return weatherData;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching weather data");
            return null;
        }
    }
}
