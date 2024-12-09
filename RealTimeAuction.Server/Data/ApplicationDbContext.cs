using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealTimeAuction.Shared.Models;

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
        /// Sees the admin user and role, and links the admin user to the admin role.
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
        }
    }
}
