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
new Customer(customerName, catalogId);

// TODO: Read from file to get updated catalog


while(true)
{
    // Display interface options
    Console.WriteLine("Select an option:");
    Console.WriteLine("1. Add item to cart");
    Console.WriteLine("2. Remove item from cart");
    Console.WriteLine("3. Exit");

    // Read user input
    input = Console.ReadLine();

    
    if (input == "1")   // Add item to cart
    {
        Console.WriteLine("Enter item name to add to cart: ");
    }
    else if (input == "2") // Remove item to cart
    {
        Console.WriteLine("Enter item name to remove from cart: ");
    }
    else if (input == "3")
    {
        Console.WriteLine("Exiting the application. Thank you!");
        break;
    }
    else
    {
        Console.WriteLine("WTF did you enter. Try again.");
        continue;
    }
}



