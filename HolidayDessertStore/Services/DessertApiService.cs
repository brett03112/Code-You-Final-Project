using System.Net.Http.Json;
using System.Text.Json;
using HolidayDessertStore.Models;
using Microsoft.Extensions.Logging;

namespace HolidayDessertStore.Services
{
    /*
    Class Overview: The DessertApiService class provides a service wrapper for API calls to the holiday dessert store.

    Class Methods:

        **Constructor (DessertApiService): Initializes the service with an HTTP client and a logger, and sets 
        up JSON serialization options.

        **Creates an HTTP client instance using the provided IHttpClientFactory.

        **Sets up the logger instance for logging during API calls.

        **Configures JSON serialization options to ignore case when deserializing property names.
    */
    public class DessertApiService : IDessertApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<DessertApiService> _logger;
        private readonly JsonSerializerOptions _jsonOptions;
        private string? _authToken;

        /// <summary>
        /// Constructor for DessertApiService, which provides a service wrapper for API calls to the holiday dessert store.
        /// </summary>
        /// <param name="httpClientFactory">The IHttpClientFactory to use for creating the HTTP client for API calls.</param>
        /// <param name="logger">The ILogger to use for logging during API calls.</param>
        /// public DessertApiService(IHttpClientFactory httpClientFactory, ILogger<DessertApiService> logger)
        {
            _httpClient = httpClientFactory.CreateClient("HolidayDessertAPI");
            _logger = logger;
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        /// <summary>
        /// Ensures that the service is authenticated with the API by checking if
        /// there is a valid auth token. If not, it attempts to authenticate with the
        /// API using the admin credentials.
        /// </summary>
        /// private async Task EnsureAuthenticatedAsync()
        {
            if (string.IsNullOrEmpty(_authToken))
            {
                var loginResponse = await _httpClient.PostAsJsonAsync("api/Auth/login", new
                {
                    Email = "admin@example.com",
                    Password = "admin00"
                });

                if (loginResponse.IsSuccessStatusCode)
                {
                    var result = await loginResponse.Content.ReadFromJsonAsync<LoginResult>();
                    _authToken = result?.Token;
                    _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authToken);
                }
                else
                {
                    throw new InvalidOperationException("Failed to authenticate with the API");
                }
            }
        }

        /// <summary>
        /// Retrieves a list of all desserts from the API.
        /// </summary>
        /// <returns>A list of all desserts, or an empty list if the API returns no results.</returns>
        /// <exception cref="HttpRequestException">If the API call fails.</exception>
        public async Task<IEnumerable<Dessert>> GetAllDessertsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/Desserts");
                response.EnsureSuccessStatusCode();
                
                var desserts = await response.Content.ReadFromJsonAsync<IEnumerable<Dessert>>(_jsonOptions);
                return desserts ?? Enumerable.Empty<Dessert>();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error fetching desserts from API");
                throw;
            }
        }


        /// <summary>
        /// This C# function asynchronously retrieves a dessert by its ID.
        /// </summary>
        /// <param name="id">The `id` parameter is an integer value that represents the unique
        /// identifier of a dessert.</param>
        public async Task<Dessert?> GetDessertByIdAsync(int id)
        {
            try
            {
                await EnsureAuthenticatedAsync();
                var response = await _httpClient.GetAsync($"api/Desserts/{id}");
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return null;
                }
                
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<Dessert>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error fetching dessert {Id} from API", id);
                throw;
            }
        }

        /// <summary>
        /// This C# function asynchronously creates a dessert object.
        /// </summary>
        /// <param name="Dessert">It looks like you are trying to create a method that asynchronously
        /// creates a dessert object. The method takes a Dessert object as a parameter.</param>
        public async Task<Dessert> CreateDessertAsync(Dessert dessert)
        {
            try
            {
                await EnsureAuthenticatedAsync();
                var response = await _httpClient.PostAsJsonAsync("api/Desserts", dessert, _jsonOptions);
                response.EnsureSuccessStatusCode();
                
                return await response.Content.ReadFromJsonAsync<Dessert>(_jsonOptions) 
                    ?? throw new InvalidOperationException("Failed to deserialize created dessert");
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error creating dessert through API");
                throw;
            }
        }

        /// <summary>
        /// This C# function asynchronously updates a dessert with the specified ID.
        /// </summary>
        /// <param name="id">The `id` parameter is an integer value that represents the unique
        /// identifier of the dessert that you want to update in the database.</param>
        /// <param name="Dessert">The `UpdateDessertAsync` method is a asynchronous method that takes in
        /// an integer `id` and a `Dessert` object as parameters. The `Dessert` object likely represents
        /// a dessert entity that you want to update in your system. The method returns a
        /// `Task<bool</param>
        public async Task<bool> UpdateDessertAsync(int id, Dessert dessert)
        {
            try
            {
                await EnsureAuthenticatedAsync();
                var response = await _httpClient.PutAsJsonAsync($"api/Desserts/{id}", dessert, _jsonOptions);
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return false;
                }
                
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error updating dessert {Id} through API", id);
                throw;
            }
        }

        /// <summary>
        /// This C# function asynchronously deletes a dessert item based on the provided ID.
        /// </summary>
        /// <param name="id">The `id` parameter in the `DeleteDessertAsync` method is an integer that
        /// represents the unique identifier of the dessert that you want to delete from the
        /// system.</param>
        public async Task<bool> DeleteDessertAsync(int id)
        {
            try
            {
                await EnsureAuthenticatedAsync();
                var response = await _httpClient.DeleteAsync($"api/Desserts/{id}");
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return false;
                }
                
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error deleting dessert {Id} through API", id);
                throw;
            }
        }

        private class LoginResult
        {
            public string? Token { get; set; }
            public DateTime Expiration { get; set; }
            public string[]? Roles { get; set; }
        }
    }
}
