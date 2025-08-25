
namespace MethodAssignment18AUG.Utility
{
    public class SumOfDigits6
    {
        public static int SumOfDigits(int number){
            int sum = 0;
        while (number > 0)
        {
            sum += number % 10; // extract last digit and add
            number /= 10;        // remove last digit
        }

        return sum;
            }
    }
}
