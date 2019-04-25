using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Models;

namespace Eshop.Services
{
    public static class ProductCatalog
    {
        public static List<Product> GetProduct()
        {
            return new List<Product>
            {
                
                new Product(1,"Fruta","Banana",55,1000),
                new Product(2,"Fruta","Orange",60,800),
                new Product(3,"Fruta","Apple", 40, 2000),
                new Product(4,"Fruta","Cherry",125,100),
                new Product(5,"Fruta","Mandarins",65,900),
                new Product(6,"Fruta","Citrus", 40, 2000),
                new Product(7,"Fruta","Limon",55,1200),
                new Product(8,"Fruta","Watermelon",6,5000),
                new Product(9,"Fruta","Melon", 20, 2000),
                new Product(10,"Fruta","Mango",55,1000),
                new Product(11,"Fruta","Peach",40,800),
                new Product(12,"Fruta","Plum", 30, 1000),
                new Product(13,"Fruta","Pears",55,1000),
                new Product(14,"Fruta","Kiwi",60,500),
                new Product(15,"Fruta","Pomegranate", 40, 2000),
                new Product(16,"Fruta","Nektarine",55,400),
                new Product(17,"Fruta","Strawberries",160,100),
                new Product(18,"Fruta","Ananas", 90, 500),
                new Product(19,"Fruta","Grapes",30,800),
                new Product(20,"Fruta","Avocado", 140, 200),
                new Product(21,"Evropa","Krembanana",5,5000),
                new Product(22,"Evropa","Dark Chocolate",65,500),
                new Product(23,"Evropa","Mini", 140, 0),
                new Product(24,"Evropa","Brixx",15,500),
                new Product(25,"Evropa","Elite Dark Chocolate",85,200),
                new Product(26,"Evropa","Cocoa", 40, 50),
                new Product(27,"Evropa","Choco Rise",55,5000),
                new Product(28,"Evropa","Metropol",65,1500),
                new Product(29,"Evropa","Jadran 500 gr", 90, 600),
                new Product(30,"Evropa","Jadran 250 gr",50,500),
                new Product(31,"Evropa","Jadran 120 gr",30,1500),
                new Product(32,"Evropa","Jadran Chocolate", 140, 100),
                new Product(33,"Nelt","Milka Noisete",45,500),
                new Product(34,"Nelt","Milka Oreo",65,500),
                new Product(35,"Nelt","Milka Alpine", 40, 500),
                new Product(36,"Nelt","Milka Bubbly",55,500),
                new Product(37,"Nelt","Milka Donuts",65,500),
                new Product(38,"Orbit","Spearmint", 25, 700),
                new Product(39,"Orbit","Winterfresh",25,500),
                new Product(40,"Orbit","Bubblemint",25,500),
                new Product(38,"Orbit","Sweetmint", 40, 0),
                new Product(39,"Orbit","White",50,500),
                new Product(40,"Orbit","Apple",65,500),
                new Product(39,"Orbit","Eucalipto",65,500),
                new Product(40,"Orbit","Orange",65,500),

            };
        }



       
    }
}
