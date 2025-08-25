

namespace Inheritance3rd.Model
{
    class Executive :Employee
    {
        //fields
        public Executive(int empNo, string name, string designation, double basicPay)
            : base(empNo, name, designation, basicPay)
        {
            if (basicPay <= 10000)
            {
                Console.WriteLine("Error: Executive's Basic Pay must be more than Rs. 10,000. Setting to 10,001");
                BasicPay = 10001; // enforce the rule
                
            }
        }

        //display method
        public override void Display()
        {
            Console.WriteLine($"[Executive] Emp No: {EmpNo}, Name: {Name}, Designation: {Designation}, Basic Pay: {BasicPay}");
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }

}

