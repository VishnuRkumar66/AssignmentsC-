
using TaskAug19.Model;

class Program
{
    static void Main()
    {
        //student details
        Console.WriteLine("---------------Student Section-----------------");
        Student student = new Student();
        Person person = new Person();
        
        student.Get_data();
        student.Show_Data();

        //employee details
        Console.WriteLine("\n------------------Employee Section ----------------");
        Employee employee = new Employee();
        employee.Get_data();
        employee.Show_Data();


        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();
        
    }
}
