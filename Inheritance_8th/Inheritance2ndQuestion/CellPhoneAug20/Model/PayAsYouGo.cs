namespace CellphoneAccountsSystem.Model
{
    public class PayAsYouGo : Account
    {
        public char Type { get; set; } // 'C' = Callmore, 'P' = Peak, 'A' = Anytime

        public PayAsYouGo(string number, double callTime, double cost, char type)
            : base(number, callTime, cost)
        {
            Type = type;
        }

        public override void DisplayAccount()
        {
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine($"PayAsYouGo Account");
            Console.WriteLine($"Number: {CellphoneNumber}");
            Console.WriteLine($"Call Time: {TotalCallTime} min" );
            Console.WriteLine($"Total Cost: {TotalCost}");
            Console.WriteLine($"Type: {Type}\n");
            Console.WriteLine("----------------------------------");

        }
    }
}
