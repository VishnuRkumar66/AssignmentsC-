using CellphoneAccountsSystem.Model;
using CellphoneAccountsSystem.Service;

namespace CellphoneAccountsSystem
{
    class Program
    {
        static void Main()
        {
            AccountSystem system = new AccountSystem(10); // can hold max 10 accounts

            bool running = true;

            while (running)
            {
                Console.WriteLine("---------- Cellphone Accounts System ---------");
                Console.WriteLine("1. Add PayAsYouGo Account");
                Console.WriteLine("2. Add Contract Account");
                Console.WriteLine("3. Display All Accounts");
                Console.WriteLine("4. Search by Number");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Invalid input!\n");
                    continue;
                }

                switch (choice)
                {
                        case 1:
                        Console.Write("Enter Number: ");
                        string num1 = Console.ReadLine();
                        Console.Write("Enter Call Time (min): ");
                        double time1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Cost: ");
                        double cost1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Type (C/P/A): ");
                        char type = Convert.ToChar(Console.ReadLine());
                        system.AddAccount(new PayAsYouGo(num1, time1, cost1, type));
                        break;
                        case 2:
                        Console.Write("Enter Number: ");
                        string num2 = Console.ReadLine();
                        Console.Write("Enter Call Time (min): ");
                        double time2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Cost: ");
                        double cost2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter Contract Length (months): ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        system.AddAccount(new Contract(num2, time2, cost2, name, address, length));
                        break;
                        case 3:
                        system.DisplayAll();
                        break;
                        case 4:
                        Console.Write("Enter Number to Search: ");
                        string search = Console.ReadLine();
                        system.SearchByNumber(search);
                        break;
                        case 5:
                        running = false;
                        break;
                        default:
                        Console.WriteLine(" Invalid choice!\n");
                        break;
                }
            }
        }
    }
}
