using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Models;
using Eshop.Services;


namespace ConsoleEshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendors = VendorService.GetVendorList();

            var products = ProductCatalog.GetProduct();

            var orderList = UserService.OrderList();
           
            
            Console.WriteLine("Please Login - Enter your Name");
            User user = new User(Console.ReadLine());
            Console.WriteLine($"Welcome {user.Name} you succsessful login on E-shop");
            Console.WriteLine("Choose one of this actions:");
            Console.WriteLine("Press 1 to Get the whole list of product vendors");    
            Console.WriteLine("Press 2 to Searh the product catalog");
            Console.WriteLine("Press 3 to Create a new Order");
            Console.WriteLine("Press 4 to finish the order nad get the final state of the Shopping cart");
            Console.WriteLine("Press 5 to Remove an existing order");
            Console.WriteLine("Press 6 to Writing an order receipt");
            Console.WriteLine("Press 0 to Exit of E-shop");
            bool startApp = true;
            while (startApp = true)
            {


                bool chooseActions = int.TryParse(Console.ReadLine(), out int action);
                if (chooseActions)
                {

                    switch (action)
                    {

                        case 1:
                            Console.WriteLine("This is whole list of product vendors:");
                            vendors.FindAll(x => x.Name == x.Name).ToList();
                            foreach (var vendor in vendors)
                            {
                                Console.WriteLine($"{vendor.Name}");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Welcome to the PRODUCT CATALOG:");
                            products.FindAll(x => x.VendorName == x.VendorName).ToList();
                            foreach (var product in products)
                            {
                                Console.WriteLine($"{product.VendorName}: {product.Name} {product.Price}");
                            }
                            break;

                        case 3:
                                                                                                                                     
                        bool orderStart = true;
                        while (orderStart = true)
                        {
                            try
                            {


                                Console.WriteLine("Choose your order by ID");
                                var orderId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter your Quantity");
                                var orderQuantity = int.Parse(Console.ReadLine());
                                var order = products.Where(x => x.Id == orderId).Take(orderQuantity).ToList();
                                foreach (var item in order)
                                {


                                    if (item.Quantity > 0)
                                    {
                                        orderList.Add(item);
                                        Console.WriteLine($"{item.Name}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("We don't have quantity from that product in this moment");
                                    }
                                }

                                Console.WriteLine("State of Shopping cart");
                                orderList.All(x => x.Name == x.Name);
                                orderList.ToList();
                                foreach (var o in orderList)
                                {
                                    Console.WriteLine($"{o.Name}, {orderQuantity} {o.Price}");
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine("Enter Valid ID");
                            }
                        }                                                                              
                            break;

                        case 4:
                            Console.WriteLine("This is your final state of Shopping cart");
                            orderStart = false;
                            break;

                        case 5:
                           

                            break;

                        case 0:
                            startApp = false;
                            Console.WriteLine("Thank you for shopping in E-shop");
                            Console.WriteLine("Please Login - Enter your Name");
                            User newUser = new User(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("Enter Valid Action !!!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Action !!!");
                }
            }
              
            Console.ReadLine();
           

        }
    }
}
