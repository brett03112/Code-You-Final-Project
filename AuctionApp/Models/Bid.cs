using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models;

public class Bid
{
    public int Id { get; set; }
    
    public decimal Price { get; set; }

    [Required]
    public string? IdentityUserId { get; set; }

    [Required]
    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }

    [Required]    
    public int? ListingId { get; set; }

    [Required]
    [ForeignKey("ListingId")]
    public Listings? Listing { get; set; }
}

