class ExceptionAssignment2
{
    static void Main()
    {
        // Simple program to demonstrate exception handling for division by zero
        try
        {
            Console.Write("Enter numerator: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denom = int.Parse(Console.ReadLine());

            int result = number / denom; // may cause DivideByZeroException
            Console.WriteLine("Result = " + result);
        }
        // Catch and handle division by zero exception
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed!");
        }
    }
}
