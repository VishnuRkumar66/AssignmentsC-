namespace BankingSystemApp.Services
{
    public interface IBank
    {
        void CreateAccount(int accountNumber, double initialBalance = 0);
        void Deposit(int accountNumber, double amount);
        void Withdraw(int accountNumber, double amount);
        void CheckBalance(int accountNumber);
    }
}
