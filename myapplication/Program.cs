using myapplication.Classes;
using myapplication.Classes.Customer;



Console.WriteLine("**********SHOPPING CART APPLICATION**********");
// Create a new customer
Console.WriteLine("Enter customer name: ");
string customerName = Console.ReadLine() ?? "Default Customer";

// Get customer catalog ID
Console.WriteLine("Enter customer catalog ID: ");
string catalogId = Console.ReadLine() ?? "12345";

// Create customer object
new Customer(customerName, "12345").DisplayCustomerInfo();


