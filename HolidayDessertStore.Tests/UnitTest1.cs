using Xunit;
using HolidayDessertStore.Models;
using HolidayDessertStore.Services;
using HolidayDessertStore.Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.Extensions.Logging;

namespace HolidayDessertStore.Tests
{
    public class ShoppingCartServiceTests
    {
        private readonly Mock<IDessertApiService> _mockDessertApiService;
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// Constructor for ShoppingCartServiceTests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This constructor initializes the <see cref="_mockDessertApiService"/> member with a new instance of
        /// <see cref="Mock{IDessertApiService}"/>, and calls the <see cref="GetTestDbContext"/> method to initialize the
        /// <see cref="_dbContext"/> member.
        /// </para>
        /// </remarks>
        public ShoppingCartServiceTests()
        {
            _mockDessertApiService = new Mock<IDessertApiService>();
            _dbContext = GetTestDbContext();
        }

        /// <summary>
        /// Gets a test <see cref="ApplicationDbContext"/> using an in-memory database.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method creates a new instance of <see cref="ApplicationDbContext"/> using an in-memory database.
        /// The in-memory database name is set to a <see cref="Guid.ToString()"/> of a new <see cref="Guid"/>.
        /// </para>
        /// <para>
        /// This method also configures the database context to ignore the
        /// <see cref="Microsoft.EntityFrameworkCore.Diagnostics.InMemoryEventId.TransactionIgnoredWarning"/>.
        /// </para>
        /// </remarks>
        /// <returns>
        /// A new instance of <see cref="ApplicationDbContext"/>.
        /// </returns>
        private ApplicationDbContext GetTestDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .ConfigureWarnings(x => x.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.InMemoryEventId.TransactionIgnoredWarning))
                .Options;
            return new ApplicationDbContext(options);
        }

        /// <summary>
        /// Tests adding a valid quantity of an item to a cart should add the item and update the stock.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This test adds a valid quantity of a dessert to a cart and asserts that the item is added
        /// and the stock is updated. The mock <see cref="IDessertApiService"/> is setup to return
        /// a valid dessert and to update the stock when called.
        /// </para>
        /// </remarks>
        /// [Fact]
        public async Task AddToCart_WithValidQuantity_ShouldAddItemAndUpdateStock()
        {
            // Arrange
            var dessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Description = "Traditional Christmas pudding",
                Price = 15.99m,
                Quantity = 10,
                IsAvailable = true
            };

            _mockDessertApiService.Setup(x => x.GetDessertByIdAsync(1))
                .ReturnsAsync(dessert);
            _mockDessertApiService.Setup(x => x.UpdateDessertAsync(1, It.Is<Dessert>(d => d.Quantity == 8)))
                .ReturnsAsync(true);

            var service = new ShoppingCartService(_dbContext, _mockDessertApiService.Object);

            // Act
            var cartItem = await service.AddToCartAsync(1, "test-cart-1", 2);

            // Assert
            Assert.NotNull(cartItem);
            Assert.Equal(2, cartItem.Quantity);
            _mockDessertApiService.Verify(x => x.UpdateDessertAsync(1, It.Is<Dessert>(d => d.Quantity == 8)), Times.Once);
        }

        /// <summary>
        /// Tests that attempting to add more items to a cart than is available should throw an exception.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This test adds a quantity of a dessert to a cart that exceeds the available quantity and
        /// asserts that an exception is thrown. The update method of the mock <see cref="IDessertApiService"/>
        /// is not called.
        /// </para>
        /// </remarks>
        /// [Fact]
        public async Task AddToCart_ExceedingAvailableQuantity_ShouldThrowException()
        {
            // Arrange
            var dessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Description = "Traditional Christmas pudding",
                Price = 15.99m,
                Quantity = 5,
                IsAvailable = true
            };

            _mockDessertApiService.Setup(x => x.GetDessertByIdAsync(1))
                .ReturnsAsync(dessert);

            var service = new ShoppingCartService(_dbContext, _mockDessertApiService.Object);

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(
                async () => await service.AddToCartAsync(1, "test-cart-1", 6)
            );
            _mockDessertApiService.Verify(x => x.UpdateDessertAsync(It.IsAny<int>(), It.IsAny<Dessert>()), Times.Never);
        }

        /// <summary>
        /// Tests that <see cref="ShoppingCartService.GetCartTotalAsync"/> can accurately calculate the total cost
        /// of all items in a cart, given that the cart contains multiple items.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This test adds two items to a cart with different prices and quantities, and asserts that the correct total
        /// cost is returned. The total cost is calculated as the sum of the price of each item multiplied by its quantity.
        /// </para>
        /// </remarks>
        /// [Fact]
        public async Task GetCartTotal_WithMultipleItems_ShouldCalculateCorrectTotal()
        {
            // Arrange
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

            _mockDessertApiService.Setup(x => x.GetDessertByIdAsync(1))
                .ReturnsAsync(dessert1);
            _mockDessertApiService.Setup(x => x.GetDessertByIdAsync(2))
                .ReturnsAsync(dessert2);
            _mockDessertApiService.Setup(x => x.UpdateDessertAsync(It.IsAny<int>(), It.IsAny<Dessert>()))
                .ReturnsAsync(true);

            var service = new ShoppingCartService(_dbContext, _mockDessertApiService.Object);

            await service.AddToCartAsync(1, "test-cart-2", 2); // 2 * 15.99
            await service.AddToCartAsync(2, "test-cart-2", 1); // 1 * 25.99

            // Act
            var total = await service.GetCartTotalAsync("test-cart-2");

            // Assert
            Assert.Equal(57.97m, total); // (2 * 15.99) + (1 * 25.99)
        }

        /// <summary>
        /// Tests that updating a cart item quantity should update the quantity and stock
        /// accordingly.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This test adds a valid quantity of a dessert to a cart, then updates the quantity
        /// of the cart item and asserts that the item's quantity is updated and the stock
        /// is updated. The mock <see cref="IDessertApiService"/> is setup to return
        /// a valid dessert and to update the stock when called.
        /// </para>
        /// </remarks>
        /// [Fact]
        public async Task UpdateCartItemQuantity_ShouldUpdateQuantityAndStock()
        {
            // Arrange
            var dessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Price = 15.99m,
                Quantity = 10
            };

            var updatedDessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Price = 15.99m,
                Quantity = 8 // Initial 10 - 2 from cart
            };

            var finalDessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Price = 15.99m,
                Quantity = 6 // After updating cart item quantity to 4
            };

            _mockDessertApiService.SetupSequence(x => x.GetDessertByIdAsync(1))
                .ReturnsAsync(dessert)      // First call during AddToCartAsync
                .ReturnsAsync(updatedDessert) // Second call during UpdateCartItemQuantityAsync
                .ReturnsAsync(finalDessert);  // Third call during GetCartItemsAsync

            _mockDessertApiService.Setup(x => x.UpdateDessertAsync(It.IsAny<int>(), It.IsAny<Dessert>()))
                .ReturnsAsync(true);

            var service = new ShoppingCartService(_dbContext, _mockDessertApiService.Object);
            var cartItem = await service.AddToCartAsync(1, "test-cart-3", 2);
            
            // Reset mock to track new calls
            _mockDessertApiService.Invocations.Clear();
            
            // Act
            await service.UpdateCartItemQuantityAsync(cartItem.Id, 4);
            var updatedItems = await service.GetCartItemsAsync("test-cart-3");
            var updatedItem = updatedItems.First();

            // Assert
            Assert.Equal(4, updatedItem.Quantity);
            _mockDessertApiService.Verify(x => x.UpdateDessertAsync(1, It.Is<Dessert>(d => d.Quantity == 6)), Times.Once);
        }

        /// <summary>
        /// Tests that removing a cart item will restore the quantity of the associated
        /// dessert to the quantity available before the item was added.
        /// </summary>
        /// [Fact]
        public async Task RemoveFromCart_ShouldRestoreStock()
        {
            // Arrange
            var dessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Price = 15.99m,
                Quantity = 10
            };

            var updatedDessert = new Dessert
            {
                Id = 1,
                Name = "Christmas Pudding",
                Price = 15.99m,
                Quantity = 8 // Initial 10 - 2 from cart
            };

            _mockDessertApiService.SetupSequence(x => x.GetDessertByIdAsync(1))
                .ReturnsAsync(dessert)      // First call during AddToCartAsync
                .ReturnsAsync(updatedDessert); // Second call during RemoveFromCartAsync

            _mockDessertApiService.Setup(x => x.UpdateDessertAsync(It.IsAny<int>(), It.IsAny<Dessert>()))
                .ReturnsAsync(true);

            var service = new ShoppingCartService(_dbContext, _mockDessertApiService.Object);
            var cartItem = await service.AddToCartAsync(1, "test-cart-4", 2);
            
            // Reset mock to track new calls
            _mockDessertApiService.Invocations.Clear();
            
            // Act
            await service.RemoveFromCartAsync(cartItem.Id);

            // Assert
            _mockDessertApiService.Verify(x => x.UpdateDessertAsync(1, It.Is<Dessert>(d => d.Quantity == 10)), Times.Once);
            Assert.Empty(await service.GetCartItemsAsync("test-cart-4"));
        }
    }
}
