using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        

    public Vendor()
        {
                
        }

        public Vendor(string name)  
        {
            Name = name;
        }
    }

    


}
