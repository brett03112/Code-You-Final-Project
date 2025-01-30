using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HolidayDessertStore.Data;
using HolidayDessertStore.Services;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Configure Stripe
var stripeSecretKey = builder.Configuration["Stripe:SecretKey"] 
    ?? throw new InvalidOperationException("Stripe:SecretKey not found in configuration");
StripeConfiguration.ApiKey = stripeSecretKey;

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();

// Register services
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<IDessertApiService, DessertApiService>();
builder.Services.AddHttpClient();
builder.Services.AddScoped<WeatherService>();

// Configure HttpClient for API
builder.Services.AddHttpClient("HolidayDessertAPI", client =>
{
    var apiBaseUrl = builder.Configuration["ApiSettings:BaseUrl"] 
        ?? throw new InvalidOperationException("API base URL not configured");
    client.BaseAddress = new Uri(apiBaseUrl);
});

// Add session support
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add authorization policies
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();
