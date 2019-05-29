using System.Collections.Generic;

namespace Eshop.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            OrderLines = new List<OrderLine>();
        }

        public List<OrderLine> OrderLines { get; set; }
    }
}
