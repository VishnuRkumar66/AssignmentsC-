namespace CollectionAssignment4.Models
{
    internal class Part
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public List<CarModel> CompatibleCars { get; set; }
        public ManufacturingCompany Manufacturer { get; set; }

        public Part(
            string code,
            string name,
            string category,
            double purchasePrice,
            double salePrice,
            ManufacturingCompany manufacturer
        )
        {
            Code = code;
            Name = name;
            Category = category;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            Manufacturer = manufacturer;
            CompatibleCars = new List<CarModel>();
        }

        public void AddCompatibleCar(CarModel car)
        {
            CompatibleCars.Add(car);
        }

        public override string ToString()
        {
            return $"[{Code}] {Name} ({Category}) | Purchase: {PurchasePrice}, Sale: {SalePrice}, Manufacturer: {Manufacturer.Name}";
        }

        public void DisplayDetails()
        {
            Console.WriteLine(this);
            Console.WriteLine("Compatible Cars:");
            foreach (var car in CompatibleCars)
            {
                Console.WriteLine($"   - {car}");
            }
            Console.WriteLine($"Made by: {Manufacturer}\n");
        }
    }
}
