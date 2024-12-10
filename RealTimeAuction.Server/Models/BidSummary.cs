using System.ComponentModel.DataAnnotations;

namespace RealTimeAuction.Server.Models
{
    public class BidSummary
    {
        [Key]
        public int BidId { get; set; }
        public decimal HighestBid { get; set; }
        public string? HighestBidder { get; set; }
        public int TotalBids { get; set; }
        public DateTime LastBidTime { get; set; }
    }
}