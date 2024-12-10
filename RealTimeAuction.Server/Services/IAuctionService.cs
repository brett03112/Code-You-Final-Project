using RealTimeAuction.Server.Models;

namespace RealTimeAuction.Server.Services
{
    public interface IAuctionService
    {
        Task<Auction> CreateAuctionAsync(Auction auction);
        Task<Auction> GetActiveAuctionAsync();
        Task<List<Auction>> GetAllAuctionsAsync();
        Task<bool> EndAuctionAsync(int auctionId);
        Task<bool> ValidateBidAsync(int dessertId, decimal bidAmount);
        Task<bool> ProcessBidAsync(int dessertId, decimal bidAmount, string userId);
        Task<Dictionary<int, BidSummary>> GetBidSummariesAsync(int auctionId);
        Task<DateTime> GetLastBidTimeForDessertAsync(int dessertId);
        Task<int> GetTotalBidsForDessertAsync(int dessertId);
    }
}