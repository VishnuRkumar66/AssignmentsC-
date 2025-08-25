namespace Class_ObjectsTwo
{
    internal class Program
    {
        public static void Main()
        {
            // Create employees
            Employee emp1 = new Employee("Vishnu R Kumar", 40000, 3);
            Employee emp2 = new Employee("Anjali", 50000, 5);

            // Display details
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }
    }
}
