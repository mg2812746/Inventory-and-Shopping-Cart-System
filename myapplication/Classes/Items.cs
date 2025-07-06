using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapplication.Classes
{
    internal class Items
    {
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public Items(string itemName, decimal price)
        {
            ItemName = itemName;
            Price = price;
        }
        public void DisplayItemInfo()
        {
            // Display item info here
        }
    }
}
