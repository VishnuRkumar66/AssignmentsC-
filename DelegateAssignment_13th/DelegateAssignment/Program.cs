namespace BankingSystem
{
    public delegate void TransactionDelegate(BankAccount account, double amount);

    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();
            int nextAccNo = 1;
            TransactionDelegate depositDelegate = new TransactionDelegate(bank.Deposit);
            TransactionDelegate withdrawDelegate = new TransactionDelegate(bank.Withdraw);

            Console.WriteLine("=== Welcome to the Banking System ===");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter initial deposit amount: ");
                        if (double.TryParse(Console.ReadLine(), out double initBal) && initBal >= 0)
                        {
                            var acc = bank.CreateAccount(nextAccNo, initBal);
                            Console.WriteLine(
                                $"Account created successfully. Account Number: {acc.AccountNumber}, Balance: {acc.Balance:C}"
                            );
                            nextAccNo++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Account not created.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter account number: ");
                        if (int.TryParse(Console.ReadLine(), out int accNoDeposit))
                        {
                            var acc = bank.GetAccount(accNoDeposit);
                            if (acc != null)
                            {
                                Console.Write("Enter deposit amount: ");
                                if (
                                    double.TryParse(Console.ReadLine(), out double depAmount)
                                    && depAmount > 0
                                )
                                {
                                    depositDelegate(acc, depAmount);
                                }
                                else
                                    Console.WriteLine("Invalid deposit amount.");
                            }
                            else
                                Console.WriteLine("Account not found.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter account number: ");
                        if (int.TryParse(Console.ReadLine(), out int accNoWithdraw))
                        {
                            var acc = bank.GetAccount(accNoWithdraw);
                            if (acc != null)
                            {
                                Console.Write("Enter withdrawal amount: ");
                                if (
                                    double.TryParse(Console.ReadLine(), out double wAmount)
                                    && wAmount > 0
                                )
                                {
                                    withdrawDelegate(acc, wAmount);
                                }
                                else
                                    Console.WriteLine("Invalid withdrawal amount.");
                            }
                            else
                                Console.WriteLine("Account not found.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter account number: ");
                        if (int.TryParse(Console.ReadLine(), out int accNoCheck))
                        {
                            var acc = bank.GetAccount(accNoCheck);
                            if (acc != null)
                            {
                                acc.ShowBalance();
                            }
                            else
                                Console.WriteLine("Account not found.");
                        }
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Thank you for using the Banking System. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
