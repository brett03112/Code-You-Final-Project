using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models;

public class Comment
{
    public int Id { get; set; }
    
    public string? Content { get; set; }

    [Required]
    public string? IdentityUserId { get; set; }

    [Required]
    [ForeignKey("IdentityUserId")]
    public IdentityUser? WinningBidder { get; set; }

    [Required]
    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }
    
    public int? ListingId { get; set; } 
    
    [Required]
    [ForeignKey("ListingId")] 
    public Listings? Listing { get; set; }
}

