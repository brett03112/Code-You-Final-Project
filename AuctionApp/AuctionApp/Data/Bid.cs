using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models;

public class Bid
{
    [Key]
    public int BidId { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal StartingBid { get; set; }

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

