using HolidayDessertStore.Models;

namespace HolidayDessertStore.Services
{
    public interface IDessertApiService
    {
        Task<IEnumerable<Dessert>> GetAllDessertsAsync();
        Task<Dessert?> GetDessertByIdAsync(int id);
        Task<Dessert> CreateDessertAsync(Dessert dessert);
        Task<bool> UpdateDessertAsync(int id, Dessert dessert);
        Task<bool> DeleteDessertAsync(int id);
    }
}
