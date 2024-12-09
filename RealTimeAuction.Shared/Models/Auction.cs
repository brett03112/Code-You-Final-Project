using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeAuction.Shared.Models
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