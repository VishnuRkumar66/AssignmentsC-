using System;

namespace CellphoneAccountsSystem.Model
{
    public class Contract : Account
    {
        public string HolderName { get; set; }
        public string Address { get; set; }
        public int ContractLength { get; set; } // in months

        public Contract(string number, double callTime, double cost, string name, string address, int length)
            : base(number, callTime, cost)
        {
            HolderName = name;
            Address = address;
            ContractLength = length;
        }

        public override void DisplayAccount()
        {
            Console.WriteLine("---------------------------\n");
            Console.WriteLine($"Contract Account");
            Console.WriteLine($"Number: {CellphoneNumber}");
            Console.WriteLine($"Call Time: {TotalCallTime} min");
            Console.WriteLine($"Total Cost: {TotalCost}");
            Console.WriteLine($"Name: {HolderName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Contract Length: {ContractLength} months\n");
           Console.WriteLine("--------------------------------");
        }
    }
}
