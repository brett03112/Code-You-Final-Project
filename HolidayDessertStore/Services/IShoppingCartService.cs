using HolidayDessertStore.Models;

namespace HolidayDessertStore.Services
{
    public interface IShoppingCartService
    {
        Task<CartItem> AddToCartAsync(int dessertId, string cartId, int quantity);
        Task<List<CartItem>> GetCartItemsAsync(string cartId);
        Task<decimal> GetCartTotalAsync(string cartId);
        Task RemoveFromCartAsync(int cartItemId);
        Task ClearCartAsync(string cartId);
        Task UpdateCartItemQuantityAsync(int cartItemId, int quantity);
        Task<int> GetAvailableQuantityAsync(int dessertId);
    }
}