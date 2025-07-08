using myapplication.Classes;

string input;
Console.WriteLine("**********SHOPPING CART APPLICATION**********");
// Create a new customer
Console.WriteLine("Enter customer name: ");
string customerName = Console.ReadLine() ?? "Default Customer";

// Create customer object
Customer customer = new Customer(customerName);

Items apple = new Items("Apple", 0.99m, 0.1m);

customer.Cart.AddItem(apple);

customer.Cart.DisplayItems();

// Check if the catalog exists
if (!File.Exists("Catalog.json"))
{
    Console.WriteLine($"Catalog file for customer Catalog.json not found. Creating a new catalog.");
    // Create a new catalog file
    throw new FileNotFoundException("THERES NOTHING HERE!");
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



