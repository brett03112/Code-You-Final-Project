using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealTimeAuction.Server.Models;

namespace RealTimeAuction.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
        /// <summary>
        /// Constructor for <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options">The options to be used by the <see cref="DbContext"/>.</param>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Dessert> Desserts { get; set; }
    public DbSet<Auction> Auctions { get; set; }

        /// <summary>
        /// Configure the model using the provided <paramref name="builder"/>.
        /// This is called after the model is built, but before the model is used
        /// to initialize the database.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method is called when the model is first created,
        /// and every time the model is updated.
        /// </para>
        /// <para>
        /// This is where seed data is usually placed.
        /// </para>
        /// </remarks>
        /// <param name="builder">The builder being used to construct the model.</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Seed admin user
        var hasher = new PasswordHasher<ApplicationUser>();
        var adminUser = new ApplicationUser
        {
            Id = "admin-id",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@dessertauction.com",
            NormalizedEmail = "ADMIN@DESSERTAUCTION.COM",
            EmailConfirmed = true
        };
        adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin00");
        builder.Entity<ApplicationUser>().HasData(adminUser);

        // Seed admin role
        builder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "admin-role-id",
            Name = "Admin",
            NormalizedName = "ADMIN"
        });

        // Link admin user to admin role
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            UserId = "admin-id",
            RoleId = "admin-role-id"
        });
    }
}
}