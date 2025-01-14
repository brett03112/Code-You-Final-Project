# CODE-YOU-FINAL-PROJECT -- HOLIDAYDESSERTSTORE

This is my Final Project for the Code: KY May 2024 Cohort. This project is a complete ecommerce site centered around a Holiday themed dessert store for a local community center. 

The project includes the following: An ASP.NET Core 9 Razor pages web application using SQLite 3 as the database provider, EntityFrameworkCore as the ORM, and uses XUnit as the testing framework for unit tests. The site consumes/uses (2) external API's: Stripe.com for payment services and weatherapi.com to showcase the local weather on the /Home page of the website.

## Authors

- [@brett03112]<https://github.com/brett03112>

## Run Locally

Clone the project

```bash
    git clone https://github.com/brett03112/Code-You-Final-Project
```

Go to the project directory

```bash
    cd Code-You-Final-Project
```

Install dependencies

```Install .Net 9
https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-9.0.101-windows-x64-installer
```

Start the app

```bash
    cd Code-You-Final-Project/HolidayDessertStore
    dotnet run -lp https
```

## Ensure that the external api keys are configured correctly

`Code-You-Final-Project/HolidayDessertStore/Services/WeatherService.cs`
`Line 97`, in the "public WeatherService(IHttpClientFactory httpClientFactory,ILogger<WeatherService> logger)"
method at `_apiKey = "";`.
The weatherapi.com api key must be entered.

`Code-You-Final-Project/HolidayDessertStore/appsettings.json`
Here you must enter the (2) API keys from Stripe.com

`SecretKey: ""`

`PublishableKey: ""`

## User Logins

primary user: `<admin@example.com>`
password: `"admin00"`

## SwaggerUI for CRUD

You must be logged in under the "admin" user role above.
Go to: [https://localhost:7056/swagger](https://localhost:7056/swagger)

## Testing

The tests are ran using an in-memory database provided by:
"Microsoft.EntityFrameworkCore.InMemory" Version="8.0.0"

Go to Code-You-Final-Project/HolidayDessertStore.Tests
Run the following: dotnet test

There are (4) tests

- public async Task AddToCart_WithValidQuantity_ShouldAddItemAndUpdateStock()
  - which tests adding items to the cart and updating the available items.
- public async Task AddToCart_ExceedingAvailableQuantity_ShouldThrowException()
  - which tests that calling the "ShoppingCartService.AddToCartAsync" with a quantity that exceeds that available stock will throw an exception.
- public async Task GetCartTotal_WithMultipleItems_ShouldCalculateCorrectTotal()
  - Make sure that the correct total is returned with multiple items in the cart.
- public async Task UpdateCartItemQuantity_ShouldUpdateQuantityAndStock()
  - Ensures that the service can correctly update the quantity of an item in a cart and update the available stock accordingly.

## All API Keys are found in the Final Project Submission form
