
namespace RealTimeAuction.Server.Models
{
    public class Auction
    {
        public int AuctionId { get; set; }
        public string AuctionName { get; set; } = string.Empty;
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive => DateTime.UtcNow >= StartingTime && DateTime.UtcNow <= EndTime;
    }
}
