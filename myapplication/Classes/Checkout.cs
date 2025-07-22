using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapplication.Classes
{
    internal class Checkout
    {
        public Checkout() { }
        public decimal ApplyDiscount(decimal discount, decimal price)
        {
            return price - (price * discount / 100);
        }
        public void ProcessPayment()
        {
            // Process payment here
            Console.WriteLine("Payment processed successfully.");
        }
    }
}
