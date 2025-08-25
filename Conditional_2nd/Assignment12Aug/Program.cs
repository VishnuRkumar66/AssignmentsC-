namespace Assignment12Aug
{
    class Program
    {
        public static void Main()
        {
            //Vote();
            //Quadrant();
            // Cls();
            //Mark();
            //Shape();
            //ElectricityBill();
            //Study();
            //Dowhile();
            //Forloop();
            //JaggedArray();
        }

        private static void Cls()
        {
            Console.Write("Enter Roll No: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter marks for Subject 1: ");
            double m1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter marks for Subject 2: ");
            double m2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter marks for Subject 3: ");
            double m3 = Convert.ToDouble(Console.ReadLine());

            double total = m1 + m2 + m3;
            double percentage = (total / 300) * 100;

            string division;
            if (percentage >= 60)
                division = "First Division";
            else if (percentage >= 50)
                division = "Second Division";
            else if (percentage >= 40)
                division = "Third Division";
            else
                division = "Fail";

            Console.WriteLine("\n******Student Result ******");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Division: {division}");
        }

        private static void Vote()
        {
            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("You are eligible to vote");
            else
                Console.WriteLine("You are below 18, you can't vote.");
        }

        private static void Quadrant()
        {
            Console.Write("Enter the X coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Y coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("The point lies in Quadrant I.");
            else if (x < 0 && y > 0)
                Console.WriteLine("The point lies in Quadrant II.");
            else if (x < 0 && y < 0)
                Console.WriteLine("The point lies in Quadrant III.");
            else if (x > 0 && y < 0)
                Console.WriteLine("The point lies in Quadrant IV.");
            else
                Console.WriteLine("The point lies at the Origin.");
        }

        private static void Mark()
        {
            // Input marks
            Console.Write("Enter marks in Mathematics: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            // Calculate totals
            int totalAll = maths + physics + chemistry;
            int totalMathPhysics = maths + physics;

            // Check eligibility
            if (
                (maths >= 65 && physics >= 55 && chemistry >= 50 && totalAll >= 180)
                || (totalMathPhysics >= 140)
            )
            {
                Console.WriteLine("\nThe candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("\nThe candidate is NOT eligible for admission.");
            }
        }

        private static void Shape()
        {
            char c = 'y';
            do
            {
                //menu driven
                Console.WriteLine("1:circle");
                Console.WriteLine("2:triangle");
                Console.WriteLine("3:square");
                Console.WriteLine("4:rectangle");
                Console.WriteLine("Enter the choice:");
                int a = Convert.ToInt32(Console.ReadLine());
                //the value is taken from user input
                switch (a)
                {
                    case 1:
                        Console.WriteLine("enter the radius:");
                        int r = Convert.ToInt32(Console.ReadLine());
                        //area is calculated..
                        Console.Write($"area is {3.14 * r * r}");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("enter the base in cm:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the height in cm:");
                        int h = Convert.ToInt32(Console.ReadLine());

                        Console.Write($"area of triangle is  {0.5 * b * h}");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("enter the side:");
                        int s = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"area of square is {s * s}");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("enter the  length:");
                        int l = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the  Breadth:");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"area of square is {l * g}");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                Console.WriteLine("y for continue ......");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y');
            Console.WriteLine("thank you for using this app......");
            Console.ReadLine();
        }

        private static void Study()
        {
            int a = 1;
            while (a <= 10)
            {
                Console.Write($" 5 x {a} = {a * 5}\n");

                a++;
            }
            Console.ReadLine();
        }

        private static void ElectricityBill()
        {
            // Input
            Console.Write("Enter Customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());

            double amount = 0;

            // Bill calculation
            if (units <= 199)
            {
                amount = units * 1.20;
            }
            else if (units >= 200 && units <= 400)
            {
                amount = units * 1.50;
            }
            else if (units >= 400 && units <= 600)
            {
                amount = units * 1.80;
            }
            else
            {
                amount = units * 2.00;
            }

            // Output
            Console.WriteLine("\n--- Electricity Bill ---");
            Console.WriteLine("Customer ID    : " + customerId);
            Console.WriteLine("Customer Name  : " + customerName);
            Console.WriteLine("Units Consumed : " + units);
            Console.WriteLine("Total Amount   : Rs. " + amount);
            Console.ReadKey();
        }

        private static void Dowhile()
        {
            char c = 'n';
            do
            {
                Console.Write("enter first number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter Second number:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1.addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.division");
                Console.WriteLine("enter the choice(1-4):");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("sum is :  " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("difference is :  " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("product is :  " + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("division is :  " + (a / b));
                        break;
                    default:
                        Console.WriteLine("enter valid choice!!!");
                        break;
                }
                //ask user to continue or not
                Console.WriteLine("Y for continue/N for exit.....");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y');
            Console.WriteLine("thank you using the calculator....");
            Console.ReadLine();
        }

        private static void Forloop()
        {
            //Diamond pattern
            int limit = 5;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(); // wait for key
            for (int i = 0; i <= limit; i++)
            {
                // Print leading spaces
                for (int j = i; j < limit; j++)
                {
                    Console.Write(" "); //Print spaces
                }
                //Print asterisk symbols
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*" + " "); //Print asterisks
                }
                Console.WriteLine(); //New line after each row
            }
            Console.ReadLine();
        }

        private static void JaggedArray()
        {
            // Jagged array = array of arrays
            int[][] jagged = new int[3][];

            // Initializing each row (each can have different lengths)
            jagged[0] = new int[] { 14, 62, 23 };
            jagged[1] = new int[] { 74, 95 };
            jagged[2] = new int[] { 62, 17, 58, 79 };

            // Printing jagged array
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write($"Mark of student {i + 1}  :"); //display
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine(); //for next line
            }

            Console.ReadKey();
        }
    }
}
