using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RealTimeAuction.Server.Hubs;
using RealTimeAuction.Shared.Data;
using RealTimeAuction.Shared.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();
builder.Services.AddCors();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapIdentityApi<ApplicationUser>();
app.MapHub<AuctionHub>("/auctionHub");

// API Endpoints
app.MapGet("/api/desserts", [Authorize(Roles = "Admin")] async (ApplicationDbContext db) =>
    await db.Desserts.ToListAsync());

/*
    /api/desserts POST (Admin Only) for creating a new dessert
*/
app.MapPost("/api/desserts", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, Dessert dessert) =>
{
    db.Desserts.Add(dessert);
    await db.SaveChangesAsync();
    return Results.Created($"/api/desserts/{dessert.DessertId}", dessert);
});

/*
    /api/desserts DELETE (Admin Only) for deleting a dessert
*/
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

/*
    /api/desserts PUT (Admin Only) for updating a dessert
*/
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

/*
    /api/auctions POST (Admin Only) for creating a new auction
*/
app.MapPost("/api/auctions", [Authorize(Roles = "Admin")] async (ApplicationDbContext db, Auction auction) =>
{
    db.Auctions.Add(auction);
    await db.SaveChangesAsync();
    return Results.Created($"/api/auctions/{auction.AuctionId}", auction);
});

/*
    /api/auctions PUT (Admin Only) for updating an auction
*/
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


/*
    /api/auctions DELETE (Admin Only) for deleting an auction
*/
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