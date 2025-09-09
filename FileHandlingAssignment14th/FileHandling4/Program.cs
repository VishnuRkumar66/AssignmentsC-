class ProductCSV
{
    // Write a program to accept product details (id, name, price, qty) for 10 products from the user
    // and store them in a CSV file named products.csv.
    static void Main()
    {
        // Define the file path
        string path = "products.csv";
        // Array to hold product details
        string[] products = new string[10];
        // Loop to get details for 10 products
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nEnter details for product {i + 1}:");
            // ID
            int id;
            while (true)
            {
                try
                {
                    Console.Write("Product ID: ");
                    id = int.Parse(Console.ReadLine());
                    break; // exit loop if valid
                }
                catch
                {
                    Console.WriteLine(
                        "Invalid input! Please enter a valid integer for Product ID."
                    );
                }
            }

            Console.Write("Product Name: ");
            string name = Console.ReadLine();
            // Price
            double price;
            while (true)
            {
                try
                {
                    Console.Write("Product Price: ");
                    price = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine(
                        "Invalid input! Please enter a valid number for Product Price."
                    );
                }
            }
            // Quantity
            int qty;
            while (true)
            {
                try
                {
                    Console.Write("Product Qty: ");
                    qty = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer for Quantity.");
                }
            }
            // Store details in CSV format
            products[i] = $"{id},{name},{price},{qty}";
        }
        // Write all product details to the CSV file
        File.WriteAllLines(path, products);
        Console.WriteLine($"\nProducts saved in {path}");
    }
}
