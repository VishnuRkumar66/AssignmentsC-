
namespace MethodAssignment18AUG.Utility
{
    public class CountNumberOfSpaces1
    {
        public static int CountNumberOfSpaces(string str)
        {
            int count = 0;
           foreach (char ch in str)
            {
                if(ch == ' ')
                {
                    count++;
                }

            }
            return count;
        }


    }
}
