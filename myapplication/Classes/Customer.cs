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
    }
}
