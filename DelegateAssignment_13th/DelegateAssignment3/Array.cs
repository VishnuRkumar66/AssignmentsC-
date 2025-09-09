using System;

namespace ArrayUtilities
{
    // Step 1: Declare delegate that takes int[] and returns int[]
    public delegate int[] ArrayOperation(int[] arr);

    public class Arrays
    {
        // Method to sort array
        public static int[] SortArray(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        // Method to reverse array
        public static int[] ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
    }
}
