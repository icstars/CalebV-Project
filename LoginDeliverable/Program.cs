using System;
using LoginLogic; 


class Program
{
    static void Main(string[] args)
    {
        Login login = new Login();

        Console.Write("Enter Username: ");
        login.User = Console.ReadLine();
        Console.Write("Enter Password: ");
        login.Pass = Console.ReadLine();

        login.Submit();
        Console.WriteLine("Enter anything to logout in 5 seconds.");
        Console.ReadLine();
        Thread.Sleep(5000);
        Console.WriteLine("Logged out.");
        Environment.Exit(0);
    }
}