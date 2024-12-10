
namespace HolidayDessertStore.Models
{
    public class StripeCheckoutFormModel
    {
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public long Amount { get; set; }
        public string? Currency { get; set; }
    }
}