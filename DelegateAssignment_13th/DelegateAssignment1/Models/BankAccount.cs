namespace DelegateAssignment1.Models
{
    internal class BankAccount
    {
        public int AccountNumber { get; }
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine(
                $"Deposited {amount:C} into account {AccountNumber}. New Balance: {Balance:C}"
            );
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine(
                    $"Withdrew {amount:C} from account {AccountNumber}. New Balance: {Balance:C}"
                );
                return true;
            }
            else
            {
                Console.WriteLine(
                    $"Withdrawal failed! Insufficient balance in account {AccountNumber}."
                );
                return false;
            }
        }
    }
}
