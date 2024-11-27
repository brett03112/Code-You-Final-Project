using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuctionApp.Models;

namespace AuctionApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    /// <summary>
    /// The application DB context. This is the main entry point of the Db
    /// and is the class that coordinates Entity Framework functionality for
    /// the whole application.
    /// </summary>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Bid> Bids { get; set; }

    public DbSet<Listings> Listings { get; set; }

    public DbSet<Comment> Comments { get; set; }


}
