using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbiCas
{
    public class Module:Part
    {
        public string Name { get; set; }
        private int _discount { get; set; }

        public Module(string name)
        {
            this.Name = name;
        }


        public Dictionary<Part, int> PartToModule = new Dictionary<Part, int>();

        public void AddPartToModule(Part part,int piece)
        {
            
            PartToModule.Add(part, piece);
        }

        public double GetPrice()
        {
          
            double total = 0;
            foreach (var part in PartToModule)
            {
                total += part.Key.Price;
            }

            return total;
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
