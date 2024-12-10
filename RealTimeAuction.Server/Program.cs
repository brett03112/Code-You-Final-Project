using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RealTimeAuction.Server.Hubs;
using RealTimeAuction.Server.Data;
using RealTimeAuction.Server.Models;
using RealTimeAuction.Server.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();
builder.Services.AddCors();
builder.Services.AddScoped<IAuctionService, AuctionService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("WebClient", policy =>
    {
        policy.WithOrigins("https://localhost:7242") // Web client URL
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("WebClient");

app.MapIdentityApi<ApplicationUser>();
app.MapHub<AuctionHub>("/auctionHub");

// API Endpoints
app.MapGet("/api/desserts", [Authorize(Roles = "Admin")] async (ApplicationDbContext db) =>
    await db.Desserts.ToListAsync());

app.MapPost("/api/desserts", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, Dessert dessert) =>
{
    db.Desserts.Add(dessert);
    await db.SaveChangesAsync();
    return Results.Created($"/api/desserts/{dessert.DessertId}", dessert);
});

app.MapDelete("/api/desserts/{id}", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, int id) =>
{
    var dessert = await db.Desserts.FindAsync(id);
    if (dessert != null)
    {
        db.Desserts.Remove(dessert);
        await db.SaveChangesAsync();
        return Results.Ok();
    }
    return Results.NotFound();
});

app.MapPut("/api/desserts/{id}", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, int id, Dessert dessert) =>
{
    var existingDessert = await db.Desserts.FindAsync(id);
    if (existingDessert != null)
    {
        existingDessert.Name = dessert.Name;
        existingDessert.Description = dessert.Description;
        existingDessert.StartingBid = dessert.StartingBid;
        await db.SaveChangesAsync();
        return Results.Ok(existingDessert);
    }
    return Results.NotFound();
});

app.MapPost("/api/auctions", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, Auction auction) =>
{
    db.Auctions.Add(auction);
    await db.SaveChangesAsync();
    return Results.Created($"/api/auctions/{auction.AuctionId}", auction);
});

app.MapPut("/api/auctions/{id}", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, int id, Auction auction) =>
{
    var existingAuction = await db.Auctions.FindAsync(id);
    if (existingAuction != null)
    {
        existingAuction.AuctionName = auction.AuctionName;
        existingAuction.StartingTime = auction.StartingTime;
        existingAuction.EndTime = auction.EndTime;
        await db.SaveChangesAsync();
        return Results.Ok(existingAuction);
    }
    return Results.NotFound();
});

app.MapDelete("/api/auctions/{id}", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, int id) =>
{
    var auction = await db.Auctions.FindAsync(id);
    if (auction != null)
    {
        db.Auctions.Remove(auction);
        await db.SaveChangesAsync();
        return Results.Ok();
    }
    return Results.NotFound();
});

app.Run();
