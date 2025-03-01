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

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter '1' for addition, '2' for subtraction, '3' for multiplication, or '4' for division and '5' for exponents.");

            answer = Console.ReadLine().ToLower();
            
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


            switch (answer)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Addition Result: {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Subtraction Result: {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Multiplication Result: {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        double Result = (double)num1 / num2;
                        Console.WriteLine($"Division Result: {Result}");
                    }
                    else
                    {
                        Console.WriteLine("Don't cause a singularity, don't divide by zero T_T.");
                    }
                    break;
                case "5":
                    double results = Math.Pow(num1, num2);
                    Console.WriteLine($"Exponent Result: {results}");
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