using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models;

public class Bid
{
    [Key]
    public int BidId { get; set; }
    
    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [Required]
    public string? IdentityUserId { get; set; }

    [Required]
    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }

    [Required]
    [Key]
    [ForeignKey("Listing")]    
    public int? ListingId { get; set; }

    [Required]
    [ForeignKey("ListingId")]
    public Listings? Listing { get; set; }
}

