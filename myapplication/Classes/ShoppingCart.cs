using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapplication.Classes
{
    internal class ShoppingCart
    {
        public List<Items> Items = new List<Items>(); // Fixed: Changed List<string> to List<Items>

        public void AddItem(Items item) // Updated parameter type to Items
        {
            Items.Add(item);
        }

        public void RemoveItem(Items item) // Updated parameter type to Items
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
                Console.WriteLine($"- {item.ItemName}, Price: {item.Price}, Discount: {item.Discount}");
            }
        }

        public void WriteCartToFile(string filePath="Cart.json")
        {
            // Write items from the cart to a file
            try
            {
                // Example: Serialize Items list to JSON and write to file
                string json = System.Text.Json.JsonSerializer.Serialize(Items);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing catalog to file: {ex.Message}");
            }
        }
    }
}
