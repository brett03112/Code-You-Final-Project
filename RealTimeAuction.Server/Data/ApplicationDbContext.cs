using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealTimeAuction.Server.Models;

namespace RealTimeAuction.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public new DbSet<ApplicationUser> Users { get; set; }
        public new DbSet<BidSummary> BidSummaries { get; set; }

        /// <summary>
        /// Configures the <see cref="DbContextOptionsBuilder"/> to suppress a warning about pending model changes that are not yet applied to the database.
        /// </summary>
        /// <param name="optionsBuilder">The <see cref="DbContextOptionsBuilder"/> to configure.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(warnings => 
                warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        /// <summary>
        /// Configures the model for the database.
        /// Seeds the admin user and role, links the admin user to the admin role, and seeds initial dessert data.
        /// </summary>
        /// <param name="builder">The <see cref="ModelBuilder"/> to configure.</param>
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

            // Seed initial dessert data
            builder.Entity<Dessert>().HasData(
                new Dessert
                {
                    DessertId = 1,
                    Name = "Orange Creamsicle Cheesecake",
                    Description = "Smooth orange-flavored cheesecake with whipped cream and fresh orange slices",
                    StartingBid = 25.00M,
                    CurrentBid = 25.00M
                },
                new Dessert
                {
                    DessertId = 2,
                    Name = "Key Lime Tart",
                    Description = "Classic key lime tart with whipped cream border",
                    StartingBid = 25.00M,
                    CurrentBid = 25.00M
                },
                new Dessert
                {
                    DessertId = 3,
                    Name = "Strawberry Shortcake",
                    Description = "Triple-layered vanilla cake with fresh strawberries and cream",
                    StartingBid = 25.00M,
                    CurrentBid = 25.00M
                },
                new Dessert
                {
                    DessertId = 4,
                    Name = "Rhubarb Pie",
                    Description = "Traditional rhubarb pie with lattice crust",
                    StartingBid = 25.00M,
                    CurrentBid = 25.00M
                },
                new Dessert
                {
                    DessertId = 5,
                    Name = "German Chocolate Bundt Cake",
                    Description = "Chocolate bundt cake with coconut filling and shavings",
                    StartingBid = 25.00M,
                    CurrentBid = 25.00M
                }
            );
        }
    }
}
