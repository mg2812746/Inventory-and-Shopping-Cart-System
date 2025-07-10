using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapplication.Classes
{
    internal class Catalog
    {
        public List<Items> Items { get; set; } 
        public Catalog()
        {
            Items = new List<Items>();
        }
        public void AddItem(Items item)
        {
            Items.Add(item);
        }
        public void RemoveItem(Items item)
        {
            Items.Remove(item);
        }
        public void DisplayCatalog()
        {
            Console.WriteLine("Catalog Items:");
            foreach (var item in Items)
            {
                Console.WriteLine($"- {item.ItemName}, Price: {item.Price}, Discount: {item.Discount}");
            }
        }
    }
}
