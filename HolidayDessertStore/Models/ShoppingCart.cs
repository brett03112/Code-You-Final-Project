using System.Collections.Generic;
using System.Linq;

namespace HolidayDessertStore.Models
{
    public class ShoppingCart
    {
        public string CartId { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal Total => Items.Sum(item => item.Price * item.Quantity);
    }
}
