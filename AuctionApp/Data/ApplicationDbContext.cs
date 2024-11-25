using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuctionApp.Models;

namespace AuctionApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Bid> Bids { get; set; }

    public DbSet<Listings> Listings { get; set; }

    public DbSet<Comment> Comments { get; set; }


}
