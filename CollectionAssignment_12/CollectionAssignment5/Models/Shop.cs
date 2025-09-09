namespace CollectionAssignment5.Models
{
    // Shop class inheriting from Estate
    public class Shop : Estate
    {
        // Indicates if the shop is located in a mall
        public bool IsInMall { get; set; }

        // Constructor
        public Shop(double area, double pricePerSqM, string location, bool isInMall)
            : base(area, pricePerSqM, location)
        {
            IsInMall = isInMall;
        }

        // Override method to display shop details

        public override void DisplayDetails()
        {
            Console.WriteLine(
                $"Shop in {Location} - {Area} m², Price: {TotalPrice}, In Mall: {IsInMall}"
            );
        }
    }
}
