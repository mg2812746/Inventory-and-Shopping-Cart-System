using myapplication.Classes;

string input;
Console.WriteLine("**********SHOPPING CART APPLICATION**********");
// Create a new customer
Console.WriteLine("Enter customer name: ");
string customerName = Console.ReadLine() ?? "Default Customer";

// Get customer catalog ID
Console.WriteLine("Enter customer catalog ID: ");
string catalogId = Console.ReadLine() ?? "12345";

// Create customer object
Customer customer = new Customer(customerName, catalogId);

// TODO: Read from file to get updated catalog otherwise create a new one

// Check if the catalog exists
if (!File.Exists($"{customer.CatalogId}.json"))
{
    Console.WriteLine($"Catalog file for customer {customer.CatalogId}.json not found. Creating a new catalog.");
    // Create a new catalog file
}


while (true)
{
    // Display interface options
    Console.WriteLine("\nSelect an option:");
    Console.WriteLine("1. Add item to cart");
    Console.WriteLine("2. Remove item from cart");
    Console.WriteLine("3. Exit\n");

    // Read user input
    input = Console.ReadLine();

    
    if (input == "1")   // Add item to cart
    {
        Console.WriteLine("\nEnter item name to add to cart: ");
    }
    else if (input == "2") // Remove item to cart
    {
        Console.WriteLine("\nEnter item name to remove from cart: ");
    }
    else if (input == "3")  // Exit the application
    {
        Console.WriteLine("\nExiting the application. Thank you!");
        break;
    }
    else // invalid input - repeat prompt
    {
        Console.WriteLine("\nWTF did you enter. Try again.");
        continue;
    }
}



