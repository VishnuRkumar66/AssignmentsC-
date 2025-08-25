namespace MethodAssignment18AUG.Utility
{
    internal class OddOrEven
    {
        public static void PrintEven(int start, int end)
        {
            if (start > end)
                return;

            if (start % 2 == 0)
                Console.Write(start + " ");

            PrintEven(start + 1, end);
        }

        // Recursive method for odd numbers
        public static void PrintOdd(int start, int end)
        {
            if (start > end)
                return;

            if (start % 2 != 0)
                Console.Write(start + " ");

            PrintOdd(start + 1, end);
        }
    }
}
