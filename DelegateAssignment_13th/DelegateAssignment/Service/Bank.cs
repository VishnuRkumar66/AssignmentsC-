namespace BankingSystem
{
    // Delegate to handle transactions

    public class Bank
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        // Create a new account
        public BankAccount CreateAccount(int accountNumber, double initialBalance = 0)
        {
            var account = new BankAccount(accountNumber, initialBalance);
            accounts[accountNumber] = account;
            return account;
        }

        // Get account by account number
        public BankAccount GetAccount(int accountNumber)
        {
            return accounts.ContainsKey(accountNumber) ? accounts[accountNumber] : null;
        }

        // Deposit method
        public void Deposit(BankAccount account, double amount)
        {
            account.Balance += amount;
            Console.WriteLine(
                $"Deposited {amount:C} successfully. New Balance: {account.Balance:C}"
            );
        }

        // Withdraw method
        public void Withdraw(BankAccount account, double amount)
        {
            if (amount > account.Balance)
            {
                Console.WriteLine($"Withdrawal of {amount:C} failed. Insufficient funds.");
            }
            else
            {
                account.Balance -= amount;
                Console.WriteLine(
                    $"Withdrew {amount:C} successfully. New Balance: {account.Balance:C}"
                );
            }
        }
    }
}
