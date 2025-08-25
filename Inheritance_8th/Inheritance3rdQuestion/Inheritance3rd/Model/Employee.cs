
namespace Inheritance3rd.Model
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double BasicPay { get; set; }

        public Employee(int empNo, string name, string designation, double basicPay)
        {
            EmpNo = empNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Emp No: {EmpNo}, Name: {Name}, Designation: " +
                $"{Designation}, Basic Pay: {BasicPay}");
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
