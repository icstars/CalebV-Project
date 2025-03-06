using System;

namespace LoginLogic
{
    class Login
    {
        public string User { get; set; }
        public string Pass { get; set; }

        public void Submit()
        {
            try
            {
                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Pass))
                {
                    throw new ArgumentException("Username or Password cannot be empty.");
                }

                if (User == "admin" && Pass == "password")
                {
                    Console.WriteLine("Admin Login Successful");
                }
                else if (User == "cv" && Pass == "issia")
                {
                    Console.WriteLine("User login Successful");
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}