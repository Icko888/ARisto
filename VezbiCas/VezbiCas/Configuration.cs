using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbiCas
{
    public class Configuration
    {
        public string Name { get; set; }
        public Colors BoxColor { get; set; }
        private int _discount { get; set; } 
        

        public Configuration(Colors black)
        {

        }

      

        public Dictionary<Module, int> ModuleToConfiguration = new Dictionary<Module, int>();

        public void AddModuleToProduct(Module module, int piece)
        {
            ModuleToConfiguration.Add(module, piece);
        }

       

        public Dictionary<Part, int> PartToConfiguration = new Dictionary<Part, int>();
        

        public void AddPartToProduct(Part part, int piece)
        {
            PartToConfiguration.Add(part, piece);
        }

       

        public double GetPrice()
        {
            double pricePart = 0;
            foreach(var part in PartToConfiguration)
            {
                pricePart += part.Key.Price;
            }
            double priceModule = 0;
            foreach(var module in ModuleToConfiguration)
            {
                priceModule += module.Key.Price;

            }
            return pricePart + priceModule;
        }

        public double SetDiscount(int discount)
        {
            this._discount = discount;
            return (GetPrice() * discount) / 100;
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() - SetDiscount(_discount);
        }

    }
}

