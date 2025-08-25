
namespace MethodAssignment18AUG.Utility
{
    public class SumOfElements2
    {
        public static int SumOfElements(int[] a)
        {
            int sum = 0;
            foreach ( int num in a)
            {
                sum += num;
            }
            return sum;
        }

    }
}
