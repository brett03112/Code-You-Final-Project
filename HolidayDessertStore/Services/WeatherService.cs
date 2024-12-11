using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace HolidayDessertStore.Services;
/*
This class definition does not contain any methods, but rather defines a 
class WeatherForecast with two properties. Here is a succinct explanation 
of what each property does:

    Current: This property represents the current weather conditions and is of type Current.

    Forecast: This property represents the forecasted weather conditions and is of type Forecast.
*/
public class WeatherForecast
{
    // Temp_f: This property represents the current temperature in Fahrenheit.
    public Current Current { get; set; } = null!;

    // Forecast: This property represents the forecasted weather conditions.
    public Forecast Forecast { get; set; } = null!;
}

public class Current
{
    // Temp_f: This property represents the current temperature in Fahrenheit.
    public double Temp_f { get; set; }

    // Condition: This property represents the current weather condition.
    public WeatherCondition Condition { get; set; } = null!;
}

public class WeatherCondition
{
    // Text: This property represents the text description of the weather condition.
    public string Text { get; set; } = string.Empty;
}

public class Forecast
{
    // Forecastday: This property represents the forecasted weather conditions for the next 4 days.
    public List<ForecastDay> Forecastday { get; set; } = new List<ForecastDay>();
}

public class ForecastDay
{
    // Day: This property represents the forecasted weather conditions for a specific day.
    public Day Day { get; set; } = null!;

    // Date: This property represents the date of the forecasted weather conditions.
    public string Date { get; set; } = string.Empty;
}

public class Day
{
    // Maxtemp_f: This property represents the maximum temperature for the day in Fahrenheit.
    public double Maxtemp_f { get; set; }

    // Mintemp_f: This property represents the minimum temperature for the day in Fahrenheit.
    public double Mintemp_f { get; set; }

    // Condition: This property represents the weather condition for the day.
    public WeatherCondition Condition { get; set; } = null!;
}

/*
Class Overview

The WeatherService class is responsible for fetching weather forecast 
data for Crab Orchard, KY.

Class Methods

    Constructor (WeatherService): Initializes the WeatherService 
    instance with an IHttpClientFactory and an ILogger.

    GetWeatherForecastAsync: Retrieves the weather forecast for 
    Crab Orchard, KY, and returns a WeatherForecast object containing 
    the current weather conditions and the forecast for the next 4 days. 
    If the data is incomplete or an error occurs, returns null.
*/
public class WeatherService
{
    // 
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly ILogger<WeatherService> _logger;

    /// <summary>
    /// Constructor for the WeatherService.
    /// </summary>
    /// <param name="httpClientFactory">IHttpClientFactory used to create a client.</param>
    /// <param name="logger">ILogger to log messages.</param>
    ///
    public WeatherService(IHttpClientFactory httpClientFactory, ILogger<WeatherService> logger)
    {
        _httpClient = httpClientFactory.CreateClient();
        _apiKey = "";
        _logger = logger;
    }

        /// <summary>
        /// Gets the weather forecast for Crab Orchard, KY.
        /// </summary>
        /// <returns>A <see cref="WeatherForecast"/> object containing the current weather conditions and the forecast for the next 4 days.</returns>
        /// <remarks>
        /// The API key is hardcoded and should be replaced with a secure method of providing the API key.
        /// </remarks>
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
