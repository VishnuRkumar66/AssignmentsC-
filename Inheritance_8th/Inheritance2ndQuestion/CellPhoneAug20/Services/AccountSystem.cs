using CellphoneAccountsSystem.Model;

namespace CellphoneAccountsSystem.Service
{
    public class AccountSystem
    {
        private Account[] accounts; // Array to hold accounts
        private int count; // Keeps track of how many accounts are stored

        public AccountSystem(int size)
        {
            accounts = new Account[size]; // Fixed size array
            count = 0;
        }

        public void AddAccount(Account acc)
        {
            if (count < accounts.Length)
            {
                accounts[count] = acc;
                count++;
                Console.WriteLine("Account added successfully!\n");
            }
            else
            {
                Console.WriteLine("Cannot add account. Array is full!\n");
            }
        }

        public void DisplayAll()
        {
            if (count == 0)
            {
                Console.WriteLine("No accounts available.\n");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                accounts[i].DisplayAccount();
            }
        }

        public void SearchByNumber(string number)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].CellphoneNumber == number)
                {
                    accounts[i].DisplayAccount();
                    return;
                }
            }
            Console.WriteLine("Account not found.\n");
        }
    }
}
