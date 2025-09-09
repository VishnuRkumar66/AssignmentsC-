using CollectionAssignment5.Models;

namespace CollectionAssignment5
{
    class Program
    {
        static void Main()
        {
            // Create Company
            Company company = new Company("Dream Homes Ltd.", "John Doe", "TAX12345");

            // Add Employees
            company.AddEmployee(new Employee("Alice", "Agent", 5));
            company.AddEmployee(new Employee("Bob", "Manager", 10));

            // Add Estates
            company.AddEstate(new Apartment(80, 1200, "Downtown", 5, true, true));
            company.AddEstate(new House(200, 900, "Suburbs", 150, 2, false));
            company.AddEstate(new UndevelopedArea(500, 300, "Countryside"));
            company.AddEstate(new Shop(60, 2000, "Shopping District", true));

            // Display everything
            company.DisplayCompanyInfo();
        }
    }
}
