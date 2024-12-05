using Microsoft.AspNetCore.Identity;

namespace CommunityCenter.Models;

public class CommunityCenterModels
{
    public class Dessert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }
        public string WinningBidderId { get; set; }
        public virtual ApplicationUser WinningBidder { get; set; }
        public virtual ICollection<Bid> Bids { get; set; }
    }

    public class Bid
    {
        public int Id { get; set; }
        public int DessertId { get; set; }
        public string BidderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public virtual Dessert Dessert { get; set; }
        public virtual ApplicationUser Bidder { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProfileImageUrl { get; set; }
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<Dessert> WonAuctions { get; set; }
    }
}
