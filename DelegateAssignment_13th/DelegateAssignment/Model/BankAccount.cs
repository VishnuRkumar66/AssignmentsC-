namespace BankingSystem
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountNumber, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"[Account {AccountNumber}] Current Balance: {Balance:C}");
        }
    }
}
