using System;

namespace CSHARP_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator program");

            Console.Write("Please enter your first number: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.Write("Please enter your second number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter '1' for addition, '2' for subtraction, '3' for multiplication, or '4' for division.");

            answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        double divisionResult = (double)num1 / num2;
                        Console.WriteLine($"The result is: {divisionResult}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }

            Console.WriteLine("Thank you for using my calculator program.");
            Environment.Exit(0);
        }
    }
}
