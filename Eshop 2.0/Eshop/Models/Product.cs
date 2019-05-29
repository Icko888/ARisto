using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
                
        }

        public Product(int id, string vendorName, string name, double price, int quantity)
        {
            Id = id;
            VendorName = vendorName;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(int id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }
    }

   
}
