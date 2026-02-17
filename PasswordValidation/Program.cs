using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main()
        {
            string password;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();

                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;
                bool hasSpecial = false;

                if (password.Length < 8)
                {
                    Console.WriteLine("Password must be at least 8 characters long.\n");
                    continue;
                }

                for (int i = 0; i < password.Length; i++)
                {
                    char ch = password[i];

                    if (ch >= 'A' && ch <= 'Z')
                        hasUpper = true;
                    else if (ch >= 'a' && ch <= 'z')
                        hasLower = true;
                    else if (ch >= '0' && ch <= '9')
                        hasDigit = true;
                    else
                        hasSpecial = true;
                }

                if (hasUpper && hasLower && hasDigit && hasSpecial)
                {
                    isValid = true;
                    Console.WriteLine("\n Password is valid!");
                }
                else
                {
                    Console.WriteLine("\n Password must contain:");
                    if (!hasUpper) Console.WriteLine("- At least one uppercase letter");
                    if (!hasLower) Console.WriteLine("- At least one lowercase letter");
                    if (!hasDigit) Console.WriteLine("- At least one digit");
                    if (!hasSpecial) Console.WriteLine("- At least one special character");
                    Console.WriteLine();
                }
            }
        }
    }
}