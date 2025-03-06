using System;

namespace LoginLogic
{
    class Login
    {
        public string User { get; set; } // get; and set; allow a better way to define and return the value for user and pass, as well as set and change it.
        public string Pass { get; set; }

        public void Submit()
        {
            try
            {
                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Pass)) // IsNullOrEmpty checks to see if the variable is null or has no data.
                {
                    throw new ArgumentException("Username or Password cannot be empty."); // Will print out if the NullOrEmpty is returned as true.
                }

                if (User == "admin" && Pass == "password") // Defines the username and password for the admin.
                {
                    Console.WriteLine("Admin Login Successful"); // Unique login message for the administrator.
                }
                else if (User == "cv" && Pass == "issia") // Username for a regular user.
                {
                    Console.WriteLine("User login Successful"); // What will print when a non-admin user logs in.
                }
                else
                {
                    Console.WriteLine("Invalid username or password."); // If the username and/or password are not "admin" and "password" or "cv" or "issia", it will print this statement
                }
            }
            catch (ArgumentException ex) // Error handling using the system function ArgumentException.
            {
                Console.WriteLine($"Error: {ex.Message}"); // will print if an ArgumentException is thrown.
            }
            catch (Exception ex) // Error handling and can be used to debug and print error codes for the program to help identify what went wrong.
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}"); // will print if an Exception is thrown.
            }
        }
    }
}