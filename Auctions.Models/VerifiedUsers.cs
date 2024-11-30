using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models
{
    public class VerifiedUsers
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        [Column(TypeName = "nvarchar(15)")]
        public string UserName { get; set; } = string.Empty;

    }
}