using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AuctionApp.Models;

public class Listings
{
   public int Id { get; set; }
   
   public string? Title { get; set; }
   
   public string? Description { get; set; }
   
   public decimal StartingBid { get; set; }
   
   public string? ImagePath { get; set; }   
   
   public decimal HighestBid { get; set; }
   
   public string? WinningBidder { get; set; }
   
   public string? IdentityUserId { get; set; }
   

   [ForeignKey("IdentityUserId")]
   public IdentityUser? User { get; set; }
   
   
}