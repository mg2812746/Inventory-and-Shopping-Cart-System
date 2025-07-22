using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapplication.Classes
{
    internal class ShoppingCart
    {
        public List<Items> Items = new List<Items>(); 

        public void AddItem(Items item) 
        {
            Items.Add(item);
        }

        public void RemoveItem(Items item) 
        {
            Items.Remove(item);
        }

        public void ClearCart()
        {
            Items.Clear();
        }
        /// <summary>
        /// Displays the items in the shopping cart.
        /// </summary>
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
                Console.WriteLine($"Cart written to {filePath} successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing catalog to file: {ex.Message}");
            }
        }
        public void ReadCartFromFile(string filePath="Cart.json")
        {
            // Read items from the file and populate the cart
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Items = System.Text.Json.JsonSerializer.Deserialize<List<Items>>(json) ?? new List<Items>();
                }
                else
                {

                    Console.WriteLine("Cart file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading cart from file: {ex.Message}");
            }
        }
    }
}
