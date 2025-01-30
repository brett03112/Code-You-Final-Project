# **HolidayDessertStore**

This is the final project for the Code: KY May 2024 cohort, a complete e-commerce site for a holiday-themed dessert store serving a local community center.

## **Project Overview**

This project is an ASP.NET Core 9 Razor Pages web application using:

- **Database:** SQLite 3
- **ORM:** Entity Framework Core
- **Testing Framework:** XUnit

The site integrates with two external APIs:

- **Stripe:** For payment processing.
- **weatherapi.com:** To display local weather on the homepage.

## **Technologies Used**

- ASP.NET Core 9
- Razor Pages
- Entity Framework Core
- SQLite
- XUnit
- Stripe API
- WeatherAPI

## **Project Structure**

The main project directories are:

- **HolidayDessertStore:** Contains the main web application.
- **HolidayDessertStore.API:** Contains the API project.
- **HolidayDessertStore.Tests:** Contains the unit tests.

Key files and directories within `HolidayDessertStore`:

- `appsettings.json`: Configuration settings for the application, including Stripe API keys.
- `Data/`: Contains the `ApplicationDbContext.cs` for database context.
- `Models/`: Contains the data models for the application.
- `Pages/`: Contains the Razor Pages for the web application.
- `Services/`: Contains services for interacting with external APIs and business logic.
- `wwwroot/`: Contains static files like CSS, JavaScript, and images.

Key files and directories within `HolidayDessertStore.API`:

- `appsettings.json`: Configuration settings for the API.
- `Controllers/`: Contains API controllers.
- `Data/`: Contains the `ApplicationDbContext.cs` for the API database context.
- `Models/`: Contains the data models for the API.

## **Authors**

- [@brett03112](https://github.com/brett03112)

## **Run Locally**

1. **Clone the repository:**

   ```bash
   git clone https://github.com/brett03112/Code-You-Final-Project
   ```

2. **Navigate to the web project directory:**

   ```bash
   cd HolidayDessertStore
   ```

3. **Install .NET 9 SDK:**
   Download and install the .NET 9 SDK from [https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-9.0.101-windows-x64-installer](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-9.0.101-windows-x64-installer)

### **API Key Configuration**

Ensure the external API keys are configured correctly:

### **WeatherAPI Key**

1. Open `HolidayDessertStore/Services/WeatherService.cs`.
2. Locate the `WeatherService` constructor.
3. Enter your weatherapi.com API key in the `_apiKey = "";` line.

   ```csharp
   public WeatherService(IHttpClientFactory httpClientFactory, ILogger<WeatherService> logger)
   {
       _httpClientFactory = httpClientFactory;
       _logger = logger;
       _apiKey = "YOUR_WEATHER_API_KEY"; // Replace with your API key
   }
   ```

### **Stripe API Keys**

1. Open `HolidayDessertStore/appsettings.json`.
2. Enter your Stripe.com API keys:

   ```json
   {
     "StripeSettings": {
       "SecretKey": "YOUR_STRIPE_SECRET_KEY",
       "PublishableKey": "YOUR_STRIPE_PUBLISHABLE_KEY"
     },
     // ... other settings
   }
   ```

## **Run the application:**

   ```bash
   dotnet run
   ```

## **User Logins**

- **APIAdmin User: (Login-api-requests.http)**
  - Username: `admin@example.com`
  - Password: `admin00`
You must be logged in under the "admin" user role above.
Go to: [https://localhost:7056/swagger](https://localhost:7056/swagger)

## Testing

Unit tests are implemented in the `HolidayDessertStore.Tests` project using an in-memory database via the `Microsoft.EntityFrameworkCore.InMemory` provider (Version 8.0.0).

To run the unit tests:

1. Navigate to the test project directory:

   ```bash
   cd HolidayDessertStore.Tests
   ```

2. Run the tests:

   ```bash
   dotnet test
   ```

### Unit Test Descriptions

- public async Task AddToCart_WithValidQuantity_ShouldAddItemAndUpdateStock()
  - which tests adding items to the cart and updating the available items.
- public async Task AddToCart_ExceedingAvailableQuantity_ShouldThrowException()
  - which tests that calling the "ShoppingCartService.AddToCartAsync" with a quantity that exceeds that available stock will throw an exception.
- public async Task GetCartTotal_WithMultipleItems_ShouldCalculateCorrectTotal()
  - Make sure that the correct total is returned with multiple items in the cart.
- public async Task UpdateCartItemQuantity_ShouldUpdateQuantityAndStock()
  - Ensures that the service can correctly update the quantity of an item in a cart and update the available stock accordingly.

The `HolidayDessertStore.Tests` project includes the following unit tests for the shopping cart service:

1. **`ShoppingCartServiceTests.AddToCart_WithValidQuantity_ShouldAddItemAndUpdateStock`**: Tests adding a valid quantity of an item to the cart and verifies that the item is added and the stock is updated.
2. **`ShoppingCartServiceTests.AddToCart_ExceedingAvailableQuantity_ShouldThrowException`**: Tests that attempting to add more items to a cart than is available should throw an exception.
3. **`ShoppingCartServiceTests.GetCartTotal_WithMultipleItems_ShouldCalculateCorrectTotal`**: Tests that the `ShoppingCartService.GetCartTotalAsync` method can accurately calculate the total cost of all items in a cart, given that the cart contains multiple items.
4. **`ShoppingCartServiceTests.UpdateCartItemQuantity_ShouldUpdateQuantityAndStock`**: Tests that updating a cart item quantity should update the quantity and stock accordingly.
5. **`ShoppingCartServiceTests.RemoveFromCart_ShouldRestoreStock`**: Tests that removing a cart item will restore the quantity of the associated dessert to the quantity available before the item was added.

## API Request Examples

Example HTTP requests can be found in the following files:

- `GET-api-requests.http`
- `POST-api-requests.http`
- `PUT-api-requests.http`
- `DELETE-api-requests.http`
- `Login-api-requests.http`

## Deployment Steps

Deployment steps are outlined in `UserInstructions.md`.

## SQL Initialization

The initial admin user is created using the script found in `InitialAdminUser.sql`.
