using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

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

    public WeatherService(IHttpClientFactory httpClientFactory, ILogger<WeatherService> logger, IConfiguration configuration)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.Timeout = TimeSpan.FromSeconds(10);
        _apiKey = configuration.GetValue<string>("WeatherApi:ApiKey") ?? throw new InvalidOperationException("WeatherApi:ApiKey not found in configuration");
        _logger = logger;
    }

    public async Task<WeatherForecast?> GetWeatherForecastAsync()
    {
        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            var response = await _httpClient.GetAsync(
                $"http://api.weatherapi.com/v1/forecast.json?key={_apiKey}&q=8305 KY-1781, Crab Orchard, KY 40419&days=3&aqi=no",
                cts.Token);
            
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync(cts.Token);
            
            _logger.LogInformation("Weather API Response: {Content}", content);

            var weatherData = JsonSerializer.Deserialize<WeatherForecast>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

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
