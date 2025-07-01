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
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C}...");
            // Simulate payment processing logic here
            Console.WriteLine("Payment processed successfully.");
        }
    }
}
