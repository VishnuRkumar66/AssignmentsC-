namespace StringAssignmentAug16
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
            //Sixth();
            Seven();
        }

        // 1. Find length of a string without library function
        private static void First()
        {
            string str = "Hello World!";
            int length = 0;
            int i = 0;

            while (i < str.Length)
            { 

                length++;
                i++;
            }

            Console.WriteLine("Length of string: " + length);
            Console.ReadLine();
        }

       

        // 2. Print individual characters of the string in reverse order
        private static void Second()
        {
            string str = "Hello";
            Console.WriteLine("String in reverse order:");

            for (int i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i] + " ");

            Console.WriteLine();
            Console.ReadLine();

        }

        // 3. Count total number of words in a string
        private static void Third()
        {
            string str = "This is a C sharp program";
            int wordCount = 0;
            bool inWord = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    if (!inWord)   // only count when we enter a new word
                    {
                        wordCount++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            Console.WriteLine($"Total number of words: {wordCount}");
            Console.ReadLine();

        }

        // 4. Compare two strings without using string library functions
        private static void Fourth()
        {
            string str1 = "hello";
            string str2 = "hello";
            bool equal = true;

            if (str1.Length != str2.Length)
            {
                equal = false;//no need to check remaining
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        equal = false;
                        break; //no need to check following.
                    }
                }
            }

            Console.WriteLine(equal ? "Strings are equal" : "Strings are not equal");
            Console.ReadLine();

        }

        // 5. Count alphabets, digits, and special characters
        private static void Fifth()
        {
            string str = "Hello123@#";
            int alphabets = 0, digits = 0, special = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))    //check alphabets count
                    alphabets++;
                else if (str[i] >= '0' && str[i] <= '9')//check numbers
                    digits++;
                else
                    special++; // special
            }

            Console.WriteLine($"Alphabets: {alphabets}, Digits: {digits}, Special characters: {special}");
            Console.ReadLine();

        }

        // 6. Extract a substring without using library function
        private static void Sixth()
        {
            string str = "HelloWorld";
            int start = 2; // starting index
            int length = 4; // how many chars to extract
            string subStr = "";

            for (int i = start; i <start +  length ; i++)
            {
                subStr += str[i];
            }

            Console.WriteLine($"Extracted substring: {subStr}");
            Console.ReadLine();

        }
        private static void Seven() { 
        //sum of digits in a mixed string...
            string str = "ab12c3d45";
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int ascii = (int)str[i]; // get ASCII value

                if (ascii >= 48 && ascii <= 57) // '0' = 48, '9' = 57
                {
                    sum += ascii - 48; // convert to int
                }
            }
            Console.WriteLine("string is " + str);
            Console.WriteLine("Sum of digits = " + sum);
            Console.ReadKey();
        }
    }

}

