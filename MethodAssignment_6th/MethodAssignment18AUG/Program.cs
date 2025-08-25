namespace MethodAssignment18AUG
{
    public class Program
    {
        static void Main()
        {
            //First();
            //Second();
            //Third();
            //Fourth();
            //Fifth();
            // Sixth();
            //Seven();
            Eight();
        }

        private static void First()
        {
            // Write a program in C# to create a method to input a
            //string and count number of spaces are in the string
            Console.WriteLine("enter String:");
            string str = Console.ReadLine();
            int result = Utility.CountNumberOfSpaces1.CountNumberOfSpaces(str);
            Console.WriteLine("total number of spaces : " + result);
        }

        private static void Second()
        {
            //Write a program in C# to calculate
            //the sum of elements in an array using methods

            Console.WriteLine("Enter how many  numbers you want to add:");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter number " + i + 1 + ":");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = Utility.SumOfElements2.SumOfElements(Arr);
            Console.WriteLine("sum is " + total);
        }

        private static void Third()
        {
            // Write a program in C# to create a method to swap the
            //values of two integer numbers
            Console.Write("enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            //before swap
            Console.WriteLine(" a :" + a + " b : " + b);

            (a, b) = Utility.SwapTwoValues3.SwapTwoValues(a, b);
            //after swap

            Console.WriteLine(" \n __ After swapping __ \n");
            Console.WriteLine(" a :" + a + " b : " + b);
        }

        private static void Fourth()
        {
            //  Write a program in C# to create a method to display the
            //n number Fibonacci sequence

            Console.WriteLine("enter the limit:");
            int limit = Convert.ToInt32(Console.ReadLine());

            Utility.Fibonacci4.Fibonacci(limit);
        }

        private static void Fifth()
        {
            //            Write a program in C# to create a method to check
            //whether a number is prime or not.

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (Utility.PrimeNumber5.PrimeNumber(number))
                Console.WriteLine($"{number} is a prime number.");
            else
                Console.WriteLine($"{number} is not a prime number.");
        }

        private static void Sixth()
        {
            //            Write a program in C# to create a method to calculate
            //the sum of the individual digits of a given number
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sum of digits :" + Utility.SumOfDigits6.SumOfDigits(number));
        }

        private static void Seven()
        {
            //           write a program in C# to display the individual digits of a
            //given number using recursion.

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digits of the number are:");
            Utility.IndividualDigit.PrintDigits(number);
        }

        private static void Eight()
        {
            //            Write a program in C to print even or odd numbers in a
            //given range using recursion

            Console.Write("Enter start of range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even numbers:");
            Utility.OddOrEven.PrintEven(start, end);

            Console.WriteLine("\nOdd numbers:");
            Utility.OddOrEven.PrintOdd(start, end);
        }
    }
}
