using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AuctionApp.Models;

public class Listings
{
   [Key]
   public int ListingId { get; set; }
   
   [Required]
   [Column(TypeName = "nvarchar(50)")]
   [StringLength(50)]
   public string? Title { get; set; }

   public string? ImagePath { get; set; }
   
   [Column(TypeName = "nvarchar(100)")]
   [StringLength(100)]
   public string? Description { get; set; }

   [Required]
   [Column(TypeName = "money")]   
   public decimal StartingBid { get; set; }   
   
   [Required]
   [Column(TypeName = "money")]
   public decimal HighestBid { get; set; }
   
   [ForeignKey("IdentityUserId")]
   public string WinningBidder { get; set; } = null!;
   
   [Required]
   public string? IdentityUserId { get; set; }

   [ForeignKey("IdentityUserId")]
   public IdentityUser? IdentityUser { get; set; }
   
   [Column(TypeName = "money")]
   public List<Bid> Bids { get; set; } = null!;  
   
}