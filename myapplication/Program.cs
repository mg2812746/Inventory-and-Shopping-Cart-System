using myapplication.Classes;

string input;
Console.WriteLine("**********SHOPPING CART APPLICATION**********");

Catalog catalog = new Catalog();
Customer customer = new Customer();
// Write the catalog from the file
catalog.AddItem(new Items("Apple", 0.5m, 0.1m));
catalog.AddItem(new Items("Banana", 0.3m, 0.05m));
catalog.AddItem(new Items("Orange", 0.7m, 0.15m));
// Display the catalog items
catalog.DisplayCatalog();


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



