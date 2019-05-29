using Eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    public static class VendorService
    {
        public static List<Vendor> GetVendorList()
        {
            return new List<Vendor>
            {
                new Vendor("Fruta"),
                new Vendor("Evropa"),
                new Vendor("Nelt"),
                new Vendor("Orbit"),
                new Vendor("Kras")
            };
        }
    }
}
