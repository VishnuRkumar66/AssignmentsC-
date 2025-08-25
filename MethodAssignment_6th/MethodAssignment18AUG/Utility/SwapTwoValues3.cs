
namespace MethodAssignment18AUG.Utility
{
    public class SwapTwoValues3
    {
        public static (int , int ) SwapTwoValues( int a, int b)
        {
            
            int temp = a;
            a = b;
            b = temp;
            return (a, b);
            
        }
    }
}
