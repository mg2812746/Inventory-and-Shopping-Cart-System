using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapplication.Classes
{
    internal class Customer
    {
        public string Name { get; set; }
        public ShoppingCart Cart = new ShoppingCart(); // needs testing
        public Customer(string name)
        {
            Name = name;
        }
        public void ReadCatalog()
        {
            // Read customer catalog from JSON file
        }
    }
}
