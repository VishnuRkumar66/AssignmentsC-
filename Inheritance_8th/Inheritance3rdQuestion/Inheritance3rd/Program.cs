using Inheritance3rd.Model;

namespace Inheritance3rd
{
    internal class Program
    {
        static void Main()
        {
            Employee employeeOne = new Employee(1, "Appu", "Clerk", 8000);
            employeeOne.Display();

            // Executive (basic pay rule applies)
            Executive executiveOne = new Executive(2, "Achu", "Executive", 9500); // Will auto-fix
            executiveOne.Display();
            //valid
            Executive executiveTwo = new Executive(3, "Malu", "Executive", 15000); 
            executiveTwo.Display();
        }
    }
}
