using Xunit;
using HolidayDessertStore.Models;
using HolidayDessertStore.Services;
using HolidayDessertStore.Data;
using Microsoft.EntityFrameworkCore;

namespace HolidayDessertStore.Tests
{
    public class ShoppingCartServiceTests
    {
        /// <summary>
        /// Returns an instance of <see cref="ApplicationDbContext"/> that is suitable for use in unit tests.
        /// </summary>
        /// <remarks>
        /// The returned context uses an in-memory database and is configured to ignore the
        /// <see cref="Microsoft.EntityFrameworkCore.Diagnostics.InMemoryEventId.TransactionIgnoredWarning"/>.
        /// </remarks>
        private ApplicationDbContext GetTestDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .ConfigureWarnings(x => x.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.InMemoryEventId.TransactionIgnoredWarning))
                .Options;
            return new ApplicationDbContext(options);
        }

        /// <summary>
        /// Verifies that calling <see cref="ShoppingCartService.AddToCartAsync"/> with a valid quantity will add the item to the cart and update the available stock.
        /// </summary>
        /// <remarks>
        /// Ensures that the available quantity of the associated dessert is reduced by the quantity of the item added to the cart.
        /// </remarks>
        [Fact]
        public async Task AddToCart_WithValidQuantity_ShouldAddItemAndUpdateStock()
        {
            // Arrange
            using var context = GetTestDbContext();
            var service = new ShoppingCartService(context);
            
            var dessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Description = "Traditional Christmas pudding",
                Price = 15.99m,
                Quantity = 10,
                IsAvailable = true
            };
            context.Desserts.Add(dessert);
            await context.SaveChangesAsync();

            // Act
            var cartItem = await service.AddToCartAsync(1, "test-cart-1", 2);

            // Assert
            Assert.NotNull(cartItem);
            Assert.Equal(2, cartItem.Quantity);
            Assert.Equal(8, await service.GetAvailableQuantityAsync(1)); // Check stock was reduced
        }

        /// <summary>
        /// Verifies that calling <see cref="ShoppingCartService.AddToCartAsync"/> with a quantity that exceeds the available stock will throw an exception.
        /// </summary>
        /// <remarks>
        /// Ensures that the service prevents adding items to a cart when there is not enough stock available.
        /// </remarks>
        [Fact]
        public async Task AddToCart_ExceedingAvailableQuantity_ShouldThrowException()
        {
            // Arrange
            using var context = GetTestDbContext();
            var service = new ShoppingCartService(context);
            
            var dessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Description = "Traditional Christmas pudding",
                Price = 15.99m,
                Quantity = 5,
                IsAvailable = true
            };
            context.Desserts.Add(dessert);
            await context.SaveChangesAsync();

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(
                async () => await service.AddToCartAsync(1, "test-cart-1", 6)
            );
        }

        /// <summary>
        /// Verifies that calling <see cref="ShoppingCartService.GetCartTotalAsync"/> returns the correct total when there are multiple items in the cart.
        /// </summary>
        /// <remarks>
        /// Ensures that the service can correctly calculate the total cost of all items in a cart.
        /// </remarks>
        [Fact]
        public async Task GetCartTotal_WithMultipleItems_ShouldCalculateCorrectTotal()
        {
            // Arrange
            using var context = GetTestDbContext();
            var service = new ShoppingCartService(context);
            
            var dessert1 = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Price = 15.99m,
                Quantity = 10
            };
            var dessert2 = new Dessert
            {
                Id = 2,
                Name = "Gingerbread House",
                Price = 25.99m,
                Quantity = 10
            };
            context.Desserts.AddRange(dessert1, dessert2);
            await context.SaveChangesAsync();

            await service.AddToCartAsync(1, "test-cart-2", 2); // 2 * 15.99
            await service.AddToCartAsync(2, "test-cart-2", 1); // 1 * 25.99

            // Act
            var total = await service.GetCartTotalAsync("test-cart-2");

            // Assert
            Assert.Equal(57.97m, total); // (2 * 15.99) + (1 * 25.99)
        }

        /// <summary>
        /// Verifies that calling <see cref="ShoppingCartService.UpdateCartItemQuantityAsync"/> with a valid quantity will update the cart item and available stock.
        /// </summary>
        /// <remarks>
        /// Ensures that the service can correctly update the quantity of an item in a cart, and update the available stock accordingly.
        /// </remarks>
        [Fact]
        public async Task UpdateCartItemQuantity_ShouldUpdateQuantityAndStock()
        {
            // Arrange
            using var context = GetTestDbContext();
            var service = new ShoppingCartService(context);
            
            var dessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Price = 15.99m,
                Quantity = 10
            };
            context.Desserts.Add(dessert);
            await context.SaveChangesAsync();

            var cartItem = await service.AddToCartAsync(1, "test-cart-3", 2);
            
            // Act
            await service.UpdateCartItemQuantityAsync(cartItem.Id, 4);
            var updatedItems = await service.GetCartItemsAsync("test-cart-3");
            var updatedItem = updatedItems.First();

            // Assert
            Assert.Equal(4, updatedItem.Quantity);
            Assert.Equal(6, await service.GetAvailableQuantityAsync(1)); // Original 10 - 4 in cart
        }
    }
}
