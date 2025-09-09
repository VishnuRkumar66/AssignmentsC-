namespace CollectionAssignment5.Models
{
    // Company class representing the real estate agency
    public class Company
    {
        // Company properties
        public string Name { get; set; }
        public string Owner { get; set; }
        public string TaxID { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Estate> Estates { get; set; }

        // Constructor
        public Company(string name, string owner, string taxID)
        {
            Name = name;
            Owner = owner;
            TaxID = taxID;
            Employees = new List<Employee>();
            Estates = new List<Estate>();
        }

        //  Methods to add employees and estates
        public void AddEmployee(Employee emp) => Employees.Add(emp);

        //  Methods to add employees and estates
        public void AddEstate(Estate estate) => Estates.Add(estate);

        // Display company info
        public void DisplayCompanyInfo()
        {
            Console.WriteLine($"Company: {Name}, Owner: {Owner}, Tax ID: {TaxID}");
            Console.WriteLine("\nEmployees:");
            foreach (var e in Employees)
                Console.WriteLine($" - {e}");
            Console.WriteLine("\nEstates for Sale:");
            foreach (var estate in Estates)
                estate.DisplayDetails();
        }
    }
}
