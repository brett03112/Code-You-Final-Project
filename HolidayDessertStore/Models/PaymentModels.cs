using System.ComponentModel.DataAnnotations;

namespace HolidayDessertStore.Models
{
    public class PaymentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PaymentIntentId { get; set; }

        [Required]
        public string ClientSecret { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; } = "usd";

        [Required]
        public string PaymentStatus { get; set; } = "Pending";

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [Required]
        public int DessertId { get; set; }
        public Dessert Dessert { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        public string CustomerName { get; set; }

        [Required]
        public string PaymentMethodId { get; set; }

        // Billing Details
        [Required]
        public string BillingAddressLine1 { get; set; }

        public string BillingAddressLine2 { get; set; }

        [Required]
        public string BillingCity { get; set; }

        [Required]
        public string BillingState { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip Code")]
        public string BillingZipCode { get; set; }

        // Shipping Details (if different from billing)
        public bool ShippingAddressSameAsBilling { get; set; } = true;

        public string ShippingAddressLine1 { get; set; }

        public string ShippingAddressLine2 { get; set; }

        public string ShippingCity { get; set; }

        public string ShippingState { get; set; }

        public string ShippingZipCode { get; set; }

        // Additional order information
        public string OrderNotes { get; set; }

        public bool IsGift { get; set; }

        public string GiftMessage { get; set; }
    }

    public class PaymentRequest
    {
        public int DessertId { get; set; }
        public int Quantity { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string PaymentMethodId { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipCode { get; set; }
        public bool ShippingAddressSameAsBilling { get; set; }
        public string ShippingAddressLine1 { get; set; }
        public string ShippingAddressLine2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZipCode { get; set; }
        public string OrderNotes { get; set; }
        public bool IsGift { get; set; }
        public string GiftMessage { get; set; }
    }

    public class PaymentResponse
    {
        public bool Success { get; set; }
        public string ClientSecret { get; set; }
        public string Message { get; set; }
        public string PaymentIntentId { get; set; }
        public string Status { get; set; }
    }
}
