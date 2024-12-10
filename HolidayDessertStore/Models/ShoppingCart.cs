using System.Collections.Generic;

namespace HolidayDessertStore.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int DessertId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Dessert Dessert { get; set; }
    }

    public class ShoppingCart
    {
        public string CartId { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal Total => Items.Sum(item => item.Price * item.Quantity);
    }
}
