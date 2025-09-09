using DelegateAssignment1.Models;

namespace BankingSystemApp.Services
{
    // Delegate for transaction events
    public delegate void TransactionDelegate(int accountNumber, double amount);

    public class Bank : IBank
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        // Events
        public event TransactionDelegate OnDeposit;
        public event TransactionDelegate OnWithdraw;

        public void CreateAccount(int accountNumber, double initialBalance = 0)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber] = new BankAccount(accountNumber, initialBalance);
                Console.WriteLine(
                    $" Account {accountNumber} created with balance {initialBalance:C}"
                );
            }
            else
            {
                Console.WriteLine(" Account already exists!");
            }
        }

        public void Deposit(int accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
                OnDeposit.Invoke(accountNumber, amount);
            else
                Console.WriteLine(" Account not found!");
        }

        public void Withdraw(int accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
                OnWithdraw.Invoke(accountNumber, amount);
            else
                Console.WriteLine(" Account not found!");
        }

        public void CheckBalance(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
                Console.WriteLine(
                    $" Account {accountNumber} Balance: {accounts[accountNumber].Balance:C}"
                );
            else
                Console.WriteLine(" Account not found!");
        }

        // Event Handlers
        public void HandleDeposit(int accountNumber, double amount) =>
            accounts[accountNumber].Deposit(amount);

        public void HandleWithdraw(int accountNumber, double amount) =>
            accounts[accountNumber].Withdraw(amount);
    }
}
