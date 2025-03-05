using NameSpaceDeliverable.Calc;
using System;

class Program
{
    static void Main()
    {
        do
        {
            Calculator calc = new Calculator();

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exponentiation");
            Console.Write("Please choose the calculation you'd like to perform (1-5): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.Write("Please input a number between 1 and 5: ");
            }

            Console.Write("Enter first number: ");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Please input a valid number: ");
            }

            Console.Write("Enter second number: ");
            int y;
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Please input a valid number: ");
            }

            double result = 0;
            string Ope = "";

            switch (choice)
            {
                case 1:
                    result = calc.Addition(x, y);
                    Ope = "Addition";
                    break;
                case 2:
                    result = calc.Subtraction(x, y);
                    Ope = "Subtraction";
                    break;
                case 3:
                    result = calc.Multiplication(x, y);
                    Ope = "Multiplication";
                    break;
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        continue;
                    }
                    result = calc.Division(x, y);
                    Ope = "Division";
                    break;
                case 5:
                    result = calc.Exponent(x, y);
                    Ope = "Exponentiation";
                    break;
            }

            Console.WriteLine($"\n{Ope} result: {result}");

            Console.Write("\nWould you like to do another calculation? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response == "no" || response == "n")
            {
                Console.WriteLine("Thank you for using the calculator!");
                Environment.Exit(0);
            }

            Console.Clear();

        } while (true);
    }
}
