namespace Class_ObjectsOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a product
            Product p1 = new Product("Laptop", 55000.75, 10);

            Console.WriteLine(p1); // Show initial details

            // Add stock
            p1.AddStock(5);

            // Try selling
            p1.Sell(3);
            p1.Sell(20); // Should fail because stock is insufficient

            Console.WriteLine("\nFinal Product Details:");
            Console.WriteLine(p1);
        }
    }
}
