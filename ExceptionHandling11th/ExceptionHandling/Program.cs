namespace ExceptionHandlingAssignment1
{
    // Write a program to take employee name and age as input from the user.
    class EmployeeInfo
    {
        // Validate that age is between 18 and 60. If not, throw an exception.
        static void Main()
        {
            try
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee Age: ");
                int age = int.Parse(Console.ReadLine());
                // Validate age range
                if (age < 18 || age > 60)
                {
                    throw new Exception("Age must be between 18 and 60!");
                }

                Console.WriteLine($"Employee Added Successfully: {name} ({age} years old)");
            }
            // Handle any exceptions that occur during input or validation
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
