using System.ComponentModel.DataAnnotations;
using CommunityCenter.Models;

namespace CommunityCenter.ViewModels
{
    public class ProfileViewModels
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string ProfileImageUrl { get; set; }

        [Display(Name = "New Profile Image")]
        public IFormFile ProfileImage { get; set; }
    }
}
