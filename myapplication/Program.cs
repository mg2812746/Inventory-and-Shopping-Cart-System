using myapplication.Classes;

string input;
Console.WriteLine("**********SHOPPING CART APPLICATION**********");

Catalog catalog = new Catalog();
Customer customer = new Customer();
// Add items to the catalog
catalog.AddItem(new Items("Apple", 0.5m, 0.1m));
catalog.AddItem(new Items("Banana", 0.3m, 0.05m));
catalog.AddItem(new Items("Orange", 0.7m, 0.15m));
catalog.AddItem(new Items("Grapes", 1.0m, 0.2m));
catalog.AddItem(new Items("Mango", 1.2m, 0.25m));

customer.Cart.ReadCartFromFile(); // Read cart items from file at the start


while (true)
{
    // Display interface options
    Console.WriteLine("\nSelect an option:");
    Console.WriteLine("1. Add item to cart");
    Console.WriteLine("2. Remove item from cart");
    Console.WriteLine("3. View cart items");
    Console.WriteLine("4. Checkout and exit");
    Console.WriteLine("5. Exit and save shopping cart to file\n");

    // Read user input
    input = Console.ReadLine();


    if (input == "1")   // Add item to cart
    {
        while (true)
        {
            catalog.DisplayCatalog(); // Display catalog before adding item
            Console.WriteLine("\nEnter item name to add to cart: ");

            input = Console.ReadLine();
            // Check if the item exists in the catalog
            var itemToAdd = catalog.Items.FirstOrDefault(i => i.ItemName.Equals(input, StringComparison.OrdinalIgnoreCase));
            customer.Cart.AddItem(itemToAdd);
            if (itemToAdd == null)  // If item does not exist, prompt user to try again
            {
                Console.WriteLine("Item not found in catalog. Please try again.");
                continue;
            }
            else // If item exists, add it to the cart
            {
                Console.WriteLine($"{itemToAdd.ItemName} added to cart successfully.");
                break;
            }
        }
    }
    else if (input == "2") // Remove item to cart
    {
        customer.Cart.DisplayItems(); // Display items in the cart before removing
        // if cart is empty, prompt user to add items first
        if (customer.Cart.Items.Count == 0)
        {
            Console.WriteLine("Your cart is empty. Please add items to the cart first.");
            continue;
        }


        Console.WriteLine("\nEnter item name to remove from cart: ");
        input = Console.ReadLine();
        // Check if the item exists in the cart
        var itemToRemove = customer.Cart.Items.FirstOrDefault(i => i.ItemName.Equals(input, StringComparison.OrdinalIgnoreCase));
        if (itemToRemove == null) // If item does not exist, prompt user to try again
        {
            Console.WriteLine("Item not found in cart. Please try again.");
            continue;
        }
        customer.Cart.RemoveItem(itemToRemove);
        Console.WriteLine($"{itemToRemove.ItemName} removed from cart successfully.");
    }
    else if (input == "3") // View cart items
    {
        customer.Cart.DisplayItems(); // Display items in the cart
    }
    else if (input == "4") // Checkout and exit
    {
        decimal finalPrice = 0;
        Checkout checkout = new Checkout();

        customer.Cart.DisplayItems(); // Display items in the cart before checkout

        if (customer.Cart.Items.Count == 0) // If cart is empty, prompt user to add items first
        {
            Console.WriteLine("Your cart is empty. Please add items to the cart first.");
            continue;
        }
        Console.WriteLine("\nProceeding to checkout...");
        // Check out
        // Apply discount 
        for (int i = 0; i < customer.Cart.Items.Count; i++)
        {
            var item = customer.Cart.Items[i];
            finalPrice += checkout.ApplyDiscount(item.Price, item.Discount); 
        }
        Console.WriteLine($"Total price after discount: {finalPrice:C}");
        checkout.ProcessPayment(); // Process payment
        // Write ShoppingCart contents to a file
        customer.Cart.ClearCart();
        break; // Exit the loop after checkout
    }
    else if (input == "5")  // Exit the application
    {
        // Write ShoppingCart contents to a file
        customer.Cart.WriteCartToFile();
        Console.WriteLine("\nExiting the application. Thank you!");
        break;
    }
    else // invalid input - repeat prompt
    {
        Console.WriteLine("\nInput invalid. Try again.");
        continue;
    }
}



