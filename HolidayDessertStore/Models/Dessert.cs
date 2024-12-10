using System.ComponentModel.DataAnnotations;

namespace HolidayDessertStore.Models
{
    public class Dessert
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required]
        public bool IsAvailable { get; set; }
    }
}