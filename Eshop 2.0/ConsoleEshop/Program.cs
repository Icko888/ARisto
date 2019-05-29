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

            var cart = new ShoppingCart();

            var orderQuantity = 0;

            double receipt = 0;

            bool startApp = true;
            while (startApp)
            {
                Console.WriteLine("Please Login - Enter your Name");
                User user = new User(Console.ReadLine());
                try
                {


                    Console.WriteLine("Press (1) to enter to E-shop");
                    var inputt = Console.ReadLine();
                    if (inputt == "1")
                    {


                        Console.WriteLine($"Welcome {user.Name} you succsessful login on E-shop");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("Choose one of this actions:");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("Press (2) to Get the whole list of product vendors");
                        Console.WriteLine("Press (3) to Searh the product catalog");
                        Console.WriteLine("Press (4) to Create a new Order");
                        Console.WriteLine("Press (5) to Search Products by Vendor Name Ordering by Ascending Price");
                        Console.WriteLine("Press (6) to Search Products by Vendor Name Ordering by Descending Price");
                        Console.WriteLine("Press (7) to Search Products by Name (Part of name)");
                        Console.WriteLine("Press (r) to Remove an existing order");
                        Console.WriteLine("Press (0) to finish the order and get the final state of the Shopping cart");
                        Console.WriteLine("Press (f) to Writing an order receipt");
                        Console.WriteLine("Press (8) to make a Payment");
                        Console.WriteLine("Press (e) to Exit of E-shop");
                        Console.WriteLine("-----------------------------------------------------");
                        if (inputt == "1")
                        {
                            var nextLayer = true;
                            while (nextLayer)
                            {
                                var inputtt = Console.ReadLine();

                                if (inputtt == "1" || inputtt == "2" || inputtt == "3" || inputtt == "4" || inputtt == "5" || inputtt == "6" || inputtt == "7" || inputtt == "8" || inputtt == "0" || inputtt == "r" || inputtt == "f" || inputtt == "e")
                                {

                                    if (inputtt == "1")
                                    {
                                        Console.WriteLine("****************************************************");
                                        Console.WriteLine($"Welcome {user.Name} you succsessful login on E-shop");
                                        Console.WriteLine("****************************************************");
                                    }

                                    if (inputtt == "2")
                                    {
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine("This is whole list of product vendors:");
                                        Console.WriteLine("----------------------------------------------------");
                                        vendors.FindAll(x => x.Name == x.Name).ToList();
                                        foreach (var vendor in vendors)
                                        {
                                            Console.WriteLine($"{vendor.Name}");
                                        }
                                    }

                                    if (inputtt == "3")
                                    {
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine("Welcome to the PRODUCT CATALOG:");
                                        Console.WriteLine("----------------------------------------------------");
                                        products.FindAll(x => x.VendorName == x.VendorName).ToList();
                                        foreach (var product in products)
                                        {
                                            Console.WriteLine($"{product.VendorName}: {product.Id}, {product.Name}, {product.Price} MKD");
                                        }
                                    }

                                    if (inputtt == "4")
                                    {
                                        bool orderProduct = true;
                                        while (orderProduct)
                                        {
                                            try
                                            {
                                                Console.WriteLine("----------------------------------------------------------------------");
                                                Console.WriteLine("Search your order by ID or Press 0 to get Final State of Shopping cart");
                                                Console.WriteLine("----------------------------------------------------------------------");
                                                var orderId = int.Parse(Console.ReadLine());
                                                if (orderId == 0)
                                                {
                                                    Console.WriteLine("-----------------------------------------");
                                                    Console.WriteLine("Final State of Shopping cart");
                                                    Console.WriteLine("-----------------------------------------");
                                                    foreach (var o in cart.OrderLines)
                                                    {
                                                        Console.WriteLine($"{o.Product.Name}, {o.Quantaty}, {o.Product.Price} MKD");
                                                    }
                                                    Console.WriteLine("-----------------------------------------");
                                                    Console.WriteLine("Press f to get your Receipt");
                                                    Console.WriteLine("-----------------------------------------");
                                                    break;

                                                }
                                                Console.WriteLine("---------------------------------------------");
                                                Console.WriteLine("Enter your Quantity");
                                                Console.WriteLine("---------------------------------------------");

                                                orderQuantity = int.Parse(Console.ReadLine());
                                                var order = products.FirstOrDefault(x => x.Id == orderId);


                                                if (order.Quantity > 0)
                                                {
                                                    order.Quantity -= orderQuantity;
                                                    var orderLine = new OrderLine()
                                                    {
                                                        Product = order,
                                                        Quantaty = orderQuantity
                                                    };

                                                    cart.OrderLines.Add(orderLine);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("----------------------------------------");
                                                    Console.WriteLine("We don't have quantity from that product");
                                                    Console.WriteLine("----------------------------------------");
                                                }

                                                Console.WriteLine("------------------------------------------");
                                                Console.WriteLine("State of Shopping cart");
                                                Console.WriteLine("------------------------------------------");
                                                foreach (var o in cart.OrderLines)
                                                {
                                                    Console.WriteLine($"{o.Product.Name}, {o.Quantaty}, {o.Product.Price} MKD");
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine("----------------------------");
                                                Console.WriteLine("Enter Valid ID");
                                                Console.WriteLine("----------------------------");
                                            }

                                        }

                                    }

                                    if (inputtt == "5")
                                    {
                                        try
                                        {

                                            Console.WriteLine("----------------------------------------------------------------------");
                                            Console.WriteLine("Search Products by Vendor Name Ordering by Ascending Price");
                                            Console.WriteLine("----------------------------------------------------------------------");
                                            var search = Console.ReadLine();
                                            var searchByVendorName = products.Where(x => x.VendorName.ToLower() == search).OrderBy(x => x.Price).ToList();
                                            if (searchByVendorName.Count > 0)
                                            {
                                                foreach (var item in searchByVendorName)
                                                {
                                                    Console.WriteLine($"{item.VendorName} -- {item.Name} --  {item.Price}");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Enter Valid Vendor name");
                                            }

                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Enter Valid Vendor name");
                                        }
                                    }

                                    if (inputtt == "6")
                                    {
                                        Console.WriteLine("----------------------------------------------------------------------");
                                        Console.WriteLine("Search Products by Vendor Name Ordering by Descending Price");
                                        Console.WriteLine("----------------------------------------------------------------------");
                                        var search1 = Console.ReadLine();
                                        var searchByVendorName = products.Where(x => x.VendorName.ToLower() == search1).OrderByDescending(x => x.Price).ToList();
                                        if (searchByVendorName.Count > 0)
                                        {
                                            foreach (var item in searchByVendorName)
                                            {
                                                Console.WriteLine($"{item.VendorName} -- {item.Name} --  {item.Price}");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Vendor name");
                                        }
                                    }

                                    if (inputtt == "7")
                                    {
                                        Console.WriteLine("----------------------------------------------------------------------");
                                        Console.WriteLine("Search Products by Name (Part of name)");
                                        Console.WriteLine("----------------------------------------------------------------------");
                                        var search2 = Console.ReadLine();
                                        var searchByPartProduct = products.Where(x => x.Name.ToLower().Contains(search2)).ToList();
                                        if (searchByPartProduct.Count > 0)
                                        {
                                            foreach (var item in searchByPartProduct)
                                            {
                                                Console.WriteLine($"{item.VendorName} -- {item.Id} -- {item.Name} -- {item.Price}");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Action");
                                        }
                                    }

                                    if (inputtt == "r")
                                    {
                                        Console.WriteLine("---------------------------------");
                                        Console.WriteLine("Remove your order");
                                        Console.WriteLine("---------------------------------");
                                        var delete = int.Parse(Console.ReadLine());
                                        cart.OrderLines.RemoveAt(delete - 1);
                                        Console.WriteLine("---------------------------------");
                                        Console.WriteLine("Final State of Shopping cart");
                                        Console.WriteLine("---------------------------------");
                                        foreach (var o in cart.OrderLines)
                                        {

                                            Console.WriteLine($"{o.Product.Name}, {o.Quantaty}, {o.Product.Price} MKD");
                                        }
                                    }

                                    if (inputtt == "f")
                                    {
                                        Console.WriteLine("---------------------------------------------");
                                        Console.WriteLine("-------------- RECEIPT------------------------");
                                        Console.WriteLine("---------------------------------------------");
                                        Console.WriteLine($"       Buyer Name: {user.Name}");
                                        Console.WriteLine("---------------------------------------------");
                                        double result = 0;

                                        foreach (var r in cart.OrderLines)
                                        {
                                            Console.WriteLine($" {r.Product.Name}, {r.Quantaty}, {r.Product.Price} MKD");
                                            result = r.Quantaty * r.Product.Price;
                                            Console.WriteLine($"               {r.Quantaty} * {r.Product.Price} = {result} MKD");
                                            receipt += result;

                                        }
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine($"             TOTAL :   {receipt} MKD");
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("Press 8 to make a Payment");
                                    }

                                    if (inputtt == "8")
                                    {
                                        Payment p = new Payment();
                                        BuyerPay b = new BuyerPay();

                                        p.PayYourOrder += b.BuyerPaymentInfo;
                                        Console.WriteLine($"{user.Name} your TOTAL Amount is {receipt} MKD");
                                        p.PaymentOrder("succsess");
                                        cart.OrderLines.RemoveAll(x => x.Product == x.Product);
                                        Console.WriteLine("Press 1 to enter to E-shop");
                                        Console.WriteLine("Press e to Exit");
                                    }

                                    if (inputtt == "e")
                                    {

                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Enter a Valid Action!!!");
                                }
                            }
                                                        
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a Valid Action!!!");

                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Enter a Valid Action!!!");
                }


            }  
            Console.ReadLine();
           

        }
    }
}
