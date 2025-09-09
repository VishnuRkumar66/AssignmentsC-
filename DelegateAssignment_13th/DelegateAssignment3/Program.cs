using ArrayUtilities;

namespace DelegateAssignment3
{
    internal class Program
    {
        static void Main()
        {
            // Sample array
            int[] numbers = { 5, 2, 9, 1, 6, 7, 4, 8, 6 };

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));
            // Step 2: Declare delegate variable
            ArrayOperation operation;

            while (true)
            {
                Console.WriteLine("\nChoose Operation:");
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. Reverse");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        operation = Arrays.SortArray;
                        break;
                    case 2:
                        operation = Arrays.ReverseArray;
                        break;
                    case 3:
                        return; // Exit application
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        continue; // Loop again
                }

                int[] result = operation((int[])numbers.Clone()); // Clone to avoid modifying original
                Console.WriteLine("Result Array: " + string.Join(", ", result));
            }
        }
    }
}
