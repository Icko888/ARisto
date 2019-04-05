using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbiCas
{
    public static class Currency
    {
        public static string PriceWithCurrency(this double getPrice, string currency )
        {
            return getPrice +" "+ currency;
        }
    }
}
