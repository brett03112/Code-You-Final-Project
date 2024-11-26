using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models;

public class Comment
{
    [Key]
    public int CommentId { get; set; }

    [Column(TypeName = "nvarchar(300)")]
    [StringLength(300)]
    public string? Content { get; set; }

    [Required]
    [ForeignKey("User")]
    public string? IdentityUserId { get; set; }

    [Required]
    [ForeignKey("IdentityUserId")]
    public IdentityUser? WinningBidder { get; set; }

    [Required]
    [ForeignKey("IdentityUserId")]
    public IdentityUser? User { get; set; }

    [Key]
    public int? ListingId { get; set; }

    [Required]
    [ForeignKey("ListingId")]
    public Listings? Listing { get; set; }
}

