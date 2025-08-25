namespace Class_ObjectsOne
{
    // Product class
    public class Product
    {
        // Fields
        private string productName;
        private double price;
        private int stockQuantity;

        // Constructor
        public Product(string productName, double price, int stockQuantity)
        {
            this.productName = productName;
            this.price = price;
            this.stockQuantity = stockQuantity;
        }

        // Method to add stock
        public void AddStock(int quantity)
        {
            if (quantity > 0)
            {
                stockQuantity += quantity;
                Console.WriteLine($"{quantity} items added. Current stock: {stockQuantity}");
            }
            else
            {
                Console.WriteLine("Quantity must be greater than 0 to add stock.");
            }
        }

        // Method to sell products
        public void Sell(int quantity)
        {
            if (quantity > 0 && quantity <= stockQuantity)
            {
                stockQuantity -= quantity;
                Console.WriteLine($"{quantity} items sold. Remaining stock: {stockQuantity}");
            }
            else if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0 to sell.");
            }
            else
            {
                Console.WriteLine("Not enough stock available!");
            }
        }

        // Override ToString() to display product details
        public override string ToString()
        {
            return $"Product: {productName}, Price: {price:C}, Stock: {stockQuantity}";
        }
    }
}
