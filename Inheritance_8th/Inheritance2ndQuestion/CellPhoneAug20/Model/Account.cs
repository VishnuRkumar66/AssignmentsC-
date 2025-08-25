namespace CellphoneAccountsSystem.Model
{
    public abstract class Account
    {
        public string CellphoneNumber { get; set; }
        public double TotalCallTime { get; set; } // in minutes
        public double TotalCost { get; set; }

        protected Account(string number, double callTime, double cost)
        {
            CellphoneNumber = number;
            TotalCallTime = callTime;
            TotalCost = cost;
        }

        public abstract void DisplayAccount();
    }
}
