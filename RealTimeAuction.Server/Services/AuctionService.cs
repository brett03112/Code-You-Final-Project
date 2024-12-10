using Microsoft.EntityFrameworkCore;
using RealTimeAuction.Server.Data;
using RealTimeAuction.Server.Models;

namespace RealTimeAuction.Server.Services
{
    public class AuctionService : IAuctionService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AuctionService> _logger;

        public AuctionService(ApplicationDbContext context, ILogger<AuctionService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Auction> CreateAuctionAsync(Auction auction)
        {
            try
            {
                // Validate auction times
                if (auction.StartingTime >= auction.EndTime)
                {
                    throw new ArgumentException("End time must be after start time");
                }

                // Check for overlapping auctions
                var existingAuction = await _context.Auctions
                    .AnyAsync(a =>
                        (auction.StartingTime >= a.StartingTime && auction.StartingTime <= a.EndTime) ||
                        (auction.EndTime >= a.StartingTime && auction.EndTime <= a.EndTime));

                if (existingAuction)
                {
                    throw new InvalidOperationException("Another auction is scheduled during this time period");
                }

                _context.Auctions.Add(auction);
                await _context.SaveChangesAsync();

                // Reset all desserts for the new auction
                var desserts = await _context.Desserts.ToListAsync();
                foreach (var dessert in desserts)
                {
                    dessert.CurrentBid = dessert.StartingBid;
                    dessert.CurrentBidUser = null;
                    dessert.WinningBid = 0;
                    dessert.WinningUser = null;
                }
                await _context.SaveChangesAsync();

                return auction;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating auction");
                throw;
            }
        }

        public async Task<Auction> GetActiveAuctionAsync()
        {
            var now = DateTime.UtcNow;
            return await _context.Auctions
                .FirstOrDefaultAsync(a =>
                    a.StartingTime <= now &&
                    a.EndTime >= now);
        }

        public async Task<List<Auction>> GetAllAuctionsAsync()
        {
            return await _context.Auctions
                .OrderByDescending(a => a.StartingTime)
                .ToListAsync();
        }

        public async Task<bool> EndAuctionAsync(int auctionId)
        {
            try
            {
                var auction = await _context.Auctions.FindAsync(auctionId);
                if (auction == null) return false;

                // Update all desserts with winning bids
                var desserts = await _context.Desserts.ToListAsync();
                foreach (var dessert in desserts)
                {
                    if (dessert.CurrentBid > dessert.StartingBid)
                    {
                        dessert.WinningBid = dessert.CurrentBid;
                        dessert.WinningUser = dessert.CurrentBidUser;
                    }
                }

                auction.EndTime = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error ending auction {AuctionId}", auctionId);
                return false;
            }
        }

        public async Task<bool> ValidateBidAsync(int dessertId, decimal bidAmount)
        {
            try
            {
                var activeAuction = await GetActiveAuctionAsync();
                if (activeAuction == null) return false;

                var dessert = await _context.Desserts.FindAsync(dessertId);
                if (dessert == null) return false;

                // Validate bid amount
                if (bidAmount <= dessert.CurrentBid) return false;
                if (bidAmount < dessert.StartingBid) return false;

                // Additional validation rules can be added here
                // For example, maximum bid increment, etc.

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error validating bid for dessert {DessertId}", dessertId);
                return false;
            }
        }

        public async Task<bool> ProcessBidAsync(int dessertId, decimal bidAmount, string userId)
        {
            try
            {
                if (!await ValidateBidAsync(dessertId, bidAmount))
                {
                    return false;
                }

                var dessert = await _context.Desserts.FindAsync(dessertId);
                dessert.CurrentBid = bidAmount;
                dessert.CurrentBidUser = userId;
                dessert.NewBid = bidAmount;

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing bid for dessert {DessertId}", dessertId);
                return false;
            }
        }

        public async Task<Dictionary<int, BidSummary>> GetBidSummariesAsync(int auctionId)
        {
            try
            {
                var desserts = await _context.Desserts.ToListAsync();
                var summaries = new Dictionary<int, BidSummary>();

                foreach (var dessert in desserts)
                {
                    summaries[dessert.DessertId] = new BidSummary
                    {
                        HighestBid = dessert.CurrentBid,
                        HighestBidder = dessert.CurrentBidUser,
                        TotalBids = await GetTotalBidsForDessertAsync(dessert.DessertId),
                        LastBidTime = await GetLastBidTimeForDessertAsync(dessert.DessertId)
                    };
                }

                return summaries;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting bid summaries for auction {AuctionId}", auctionId);
                throw;
            }
        }

        public async Task<DateTime> GetLastBidTimeForDessertAsync(int dessertId)
        {
            try
            {
                var bidSummary = await _context.BidSummaries
                    .Where(bs => bs.BidId == dessertId)
                    .FirstOrDefaultAsync();

                return bidSummary?.LastBidTime ?? DateTime.MinValue;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting last bid time for dessert {DessertId}", dessertId);
                return DateTime.MinValue;
            }
        }

        public async Task<int> GetTotalBidsForDessertAsync(int dessertId)
        {
            try
            {
                var bidSummary = await _context.BidSummaries
                    .Where(bs => bs.BidId == dessertId)
                    .FirstOrDefaultAsync();

                return bidSummary?.TotalBids ?? 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting total bids for dessert {DessertId}", dessertId);
                return 0;
            }
        }
    }
}
