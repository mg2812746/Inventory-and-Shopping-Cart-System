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
        public string CatalogId { get; set; } = string.Empty;
        public Customer(string name, string catalogId)
        {
            Name = name;
            CatalogId = catalogId;
        }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Catalog ID: {CatalogId}");
        }
        public void UpdateCatalogId(string newCatalogId)
        {
            CatalogId = newCatalogId;
            Console.WriteLine($"Catalog ID updated to: {CatalogId}");
        }
    }
}
