using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Code_You_Auction_App.Models;

public class Bid
{
    public int Id { get; set; }
    
    public decimal Price { get; set; }

    [Required]
    public string? IdentityUserId { get; set; }


    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }
    
    public int? ListingId { get; set; }

    [ForeignKey("ListingId")]
    public Listing? Listing { get; set; }
}

