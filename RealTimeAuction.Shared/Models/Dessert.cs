using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeAuction.Shared.Models
{
    public class Dessert
    {
        public int DessertId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? DessertImage { get; set; }
        public decimal StartingBid { get; set; } = 25.00M;
        public decimal CurrentBid { get; set; }
        public string CurrentBidUser { get; set; } = string.Empty;
        public decimal NewBid { get; set; }
        public decimal WinningBid { get; set; }
        public string WinningUser { get; set; } = string.Empty;
    }
}