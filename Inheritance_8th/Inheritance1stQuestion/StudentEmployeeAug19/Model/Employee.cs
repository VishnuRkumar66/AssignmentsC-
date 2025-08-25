
namespace TaskAug19.Model
{
    public class Employee : Person
    {
        // Fields
        public double BP { get; set; }  // Basic Pay
        public double HR { get; set; }  // HR
        public double Salary{ get; set; } // Net Salary

        // default Constructor

        public Employee() { }

        //parameterized constructor
        public Employee(string name, int age, double bp, double hr) : base(name, age)
        {
            BP = bp;
            HR = hr;
            Salary = 0;
        }

        // Method to input employee data
        public void Get_data()
        {
            Read_data();

            Console.Write("Enter Basic Pay (BP): ");
            BP = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter HRA: ");
            HR = Convert.ToDouble(Console.ReadLine());
        }

        // Compute Salary
        public double Compute_Salary()
        {
            Salary = BP + HR;
            return Salary;
        }

        // Show Employee Data
        public void Show_Data()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Display_Data();
            Console.WriteLine($"Basic Pay: {BP}");
            Console.WriteLine($"HRA: {HR}");
            Console.WriteLine($"Net Salary: {Compute_Salary()}");
        }
    }
}
