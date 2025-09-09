namespace CollectionAssignment4.Models
{
    internal class CarModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public CarModel(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}, {Year}";
        }
    }
}
