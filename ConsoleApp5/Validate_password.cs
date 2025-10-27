using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Validate_password
    {
        public void validate_pass()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSymbol = false;

            
            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];

                if (c >= 'A' && c <= 'Z')
                    hasUpper = true;
                else if (c >= 'a' && c <= 'z')
                    hasLower = true;
                else if (c >= '0' && c <= '9')
                    hasDigit = true;
                else
                    hasSymbol = true;  
            }

           
            if (password.Length >= 8 && hasUpper && hasLower && hasDigit && hasSymbol)
                Console.WriteLine(" Strong password!");
            else
            {
                Console.WriteLine(" Weak password. Please ensure the following:");
                if (password.Length < 8)
                    Console.WriteLine("- At least 8 characters long");
                if (!hasUpper)
                    Console.WriteLine("- Contains an uppercase letter");
                if (!hasLower)
                    Console.WriteLine("- Contains a lowercase letter");
                if (!hasDigit)
                    Console.WriteLine("- Contains at least one number");
                if (!hasSymbol)
                    Console.WriteLine("- Contains at least one special symbol (e.g., @, #, $, %)");
            }
        }
    }
    
}
