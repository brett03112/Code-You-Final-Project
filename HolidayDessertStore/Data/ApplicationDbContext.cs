using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using HolidayDessertStore.Models;

namespace HolidayDessertStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<PaymentModel> Payments { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(warnings => 
                warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure CartItem
            builder.Entity<CartItem>()
                .HasOne(c => c.Dessert)
                .WithMany()
                .HasForeignKey(c => c.DessertId);

            // Configure PaymentModel
            builder.Entity<PaymentModel>()
                .HasOne(p => p.Dessert)
                .WithMany()
                .HasForeignKey(p => p.DessertId);

            // Seed Admin User
            var hasher = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser
            {
                Id = "1",
                UserName = "admin@example.com",
                Email = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin00");

            builder.Entity<IdentityUser>().HasData(adminUser);

            // Create admin role
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );

            // Add admin user to admin role
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }
            );

            // Seed Desserts
            builder.Entity<Dessert>().HasData(
                new Dessert
                {
                    Id = 1,
                    Name = "Orange Creamsicle Cheesecake",
                    Description = "Smooth cheesecake topped with orange glaze and fresh orange slices, decorated with whipped cream rosettes",
                    Price = 45.99M,
                    ImagePath = "/images/desserts/orange_slice_cheesecake.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 2,
                    Name = "Key Lime Tart",
                    Description = "Classic key lime tart with graham cracker crust and whipped cream border",
                    Price = 35.99M,
                    ImagePath = "/images/desserts/key_lime_pie.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 3,
                    Name = "Rhubarb Pie",
                    Description = "Traditional rhubarb pie with lattice top crust and crystallized sugar finish",
                    Price = 32.99M,
                    ImagePath = "/images/desserts/strawberry_rhubarb_pie.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 4,
                    Name = "Strawberry Layer Cake",
                    Description = "Three-layer vanilla cake with fresh strawberries and whipped cream frosting",
                    Price = 48.99M,
                    ImagePath = "/images/desserts/strawberry_shortcake.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 5,
                    Name = "German Chocolate Bundt Cake",
                    Description = "Chocolate bundt cake filled with coconut-pecan filling and topped with shredded coconut",
                    Price = 39.99M,
                    ImagePath = "/images/desserts/German_chocolate_bundt_cake.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 6,
                    Name = "Double Chocolate Fudge Brownies",
                    Description = "Rich, gooey brownies with melted chocolate centers, perfect for chocolate lovers",
                    Price = 24.99M,
                    ImagePath = "/images/desserts/brownies.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 7,
                    Name = "Holiday Snickerdoodle Cookies",
                    Description = "Classic cinnamon-sugar cookies with a festive twist, perfect with hot cocoa",
                    Price = 18.99M,
                    ImagePath = "/images/desserts/snickerdoodle_cookies.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 8,
                    Name = "Fresh Peach Cobbler",
                    Description = "Warm, flaky crust filled with sweet peaches and spices, served with candlelight ambiance",
                    Price = 28.99M,
                    ImagePath = "/images/desserts/peach_cobbler.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 9,
                    Name = "Classic Apple Pie",
                    Description = "Traditional lattice-topped apple pie with cinnamon and spices, surrounded by fall decorations",
                    Price = 32.99M,
                    ImagePath = "/images/desserts/apple_pie.jpg",
                    Quantity = 10,
                    IsAvailable = true
                },
                new Dessert
                {
                    Id = 10,
                    Name = "Banana Pudding Delight",
                    Description = "Creamy vanilla pudding layered with fresh bananas, vanilla wafers, and caramel drizzle",
                    Price = 22.99M,
                    ImagePath = "/images/desserts/banana_pudding.jpg",
                    Quantity = 10,
                    IsAvailable = true
                }
            );
        }
    }
}
