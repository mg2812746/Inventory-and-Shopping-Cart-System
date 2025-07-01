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
            Console.WriteLine($"Item Name: {ItemName}");
            Console.WriteLine($"Price: {Price:C}");
        }
        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;
            Console.WriteLine($"Price updated to: {Price:C}");
        }
    }
}
