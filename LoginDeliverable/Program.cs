using System;
using LoginLogic; 


class Program
{
    static void Main(string[] args)
    {
        Login login = new Login(); // Links the login class from the other namespace to this file.

        Console.Write("Enter Username: ");
        login.User = Console.ReadLine();
        Console.Write("Enter Password: ");
        login.Pass = Console.ReadLine();

        login.Submit(); // runs the code from lines 10 to 40 in the login.cs file.
        Console.WriteLine("Enter anything to logout in 5 seconds.");
        Console.ReadLine();
        Thread.Sleep(5000); // Waits 5 seconds
        Console.WriteLine("Logged out.");
        Environment.Exit(0); // Quits the program.
    }
}