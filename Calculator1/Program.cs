using System;

namespace CSHARP_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                int num1, num2, result = 0;
                string answer;

                Console.WriteLine("Hello, welcome to the calculator program");

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter '1' for addition, '2' for subtraction, '3' for multiplication, '4' for division, or '5' for exponents.");

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
                            double divisionResult = (double)num1 / num2;
                            Console.WriteLine($"Division Result: {divisionResult}");
                        }
                        else
                        {
                            Console.WriteLine("Don't cause a singularity, don't divide by zero T_T.");
                        }
                        break;
                    case "5":
                        double exponentResult = Math.Pow(num1, num2);
                        Console.WriteLine($"Exponent Result: {exponentResult}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        break;
                }

                // Ask if the user wants to continue
                Console.Write("Would you like to perform another calculation? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response == "n" || response == "no")
                {
                    continueCalculating = false;
                    Console.WriteLine("Thank you for using my calculator program. Goodbye!");
                }
            }
        }
    }
}
