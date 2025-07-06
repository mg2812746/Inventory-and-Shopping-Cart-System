using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapplication.Classes
{
    internal class ShoppingCart
    {
        public List<string> Items { get; set; } = new List<string>(); // TODO: List needs to be list of Item objects
        public void AddItem(string item)
        {
            Items.Add(item);
        }
        public void RemoveItem(string item)
        {
            Items.Remove(item);
        }
        public void ClearCart()
        {
            Items.Clear();
        }
        public void DisplayItems()
        {
            Console.WriteLine("Items in the cart:");
            foreach (var item in Items)
            {
                Console.WriteLine($"- {item}");
            }
        }
        public void WriteToFile(string filePath)
        {
            // Write items from the cart to a file
        }
    }
}
