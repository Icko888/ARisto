using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Eshop.Models;
using Eshop.Services;

namespace Eshop.Models
{
    

    public delegate void PaymentProcess(string message);
    public class Payment
    {
        
        public event PaymentProcess PayYourOrder;

        public void PaymentOrder(string message)
        {
            Console.WriteLine("Enter your 16 Digit Card Number");
            long inputYourCardNumber = long.Parse(Console.ReadLine());
            Thread.Sleep(3000);
            Console.WriteLine("Enter your CVV Number");
            int inputYourCvvNumber = int.Parse(Console.ReadLine());
            Thread.Sleep(3000);
            Console.WriteLine($"Your Payment is {message}");

        }

        protected virtual void NotifyAllSubscribers(string message)
        {
            PayYourOrder?.Invoke(message);
        }
    }

    public class BuyerPay
    {
        public void BuyerPaymentInfo(string message)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"{message}");
        }
    }
}
