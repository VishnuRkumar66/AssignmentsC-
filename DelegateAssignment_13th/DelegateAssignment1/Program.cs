using System;
using BankingSystemApp.Services;

namespace BankingSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the IBank interface to interact with the banking system
            IBank bank = new Bank();

            // Cast back to Bank so we can subscribe to events
            Bank concreteBank = (Bank)bank;
            concreteBank.OnDeposit += concreteBank.HandleDeposit;
            concreteBank.OnWithdraw += concreteBank.HandleWithdraw;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Banking System Menu ---");
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
                        Console.Write("Enter new Account Number: ");
                        if (int.TryParse(Console.ReadLine(), out int newAcc))
                        {
                            Console.Write("Enter initial balance: ");
                            double.TryParse(Console.ReadLine(), out double initBalance);
                            bank.CreateAccount(newAcc, initBalance);
                        }
                        else
                            Console.WriteLine("Invalid account number!");
                        break;

                    case "2":
                        Console.Write("Enter account number: ");
                        if (int.TryParse(Console.ReadLine(), out int dAcc))
                        {
                            Console.Write("Enter deposit amount: ");
                            if (double.TryParse(Console.ReadLine(), out double depAmount))
                                bank.Deposit(dAcc, depAmount);
                            else
                                Console.WriteLine("Invalid amount!");
                        }
                        break;

                    case "3":
                        Console.Write("Enter account number: ");
                        if (int.TryParse(Console.ReadLine(), out int wAcc))
                        {
                            Console.Write("Enter withdrawal amount: ");
                            if (double.TryParse(Console.ReadLine(), out double wAmount))
                                bank.Withdraw(wAcc, wAmount);
                            else
                                Console.WriteLine("Invalid amount!");
                        }
                        break;

                    case "4":
                        Console.Write("Enter account number: ");
                        if (int.TryParse(Console.ReadLine(), out int cAcc))
                            bank.CheckBalance(cAcc);
                        else
                            Console.WriteLine("Invalid account number!");
                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }

            Console.WriteLine(" Thank you for using the Banking System!");
        }
    }
}
