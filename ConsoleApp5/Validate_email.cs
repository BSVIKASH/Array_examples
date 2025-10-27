using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Validate_email
    {
        public void validate()
        {
            Console.Write("Enter the email address: ");
            string email = Console.ReadLine();

            
            if (email.Contains("@") && email.Contains("."))
            {
                int atPosition = email.IndexOf("@");
                int dotPosition = email.LastIndexOf(".");

               
                if (atPosition < dotPosition && atPosition > 0 && dotPosition < email.Length - 1)
                {
                    Console.WriteLine("Valid email address.");
                }
                else
                {
                    Console.WriteLine("Invalid email address.");
                }
            }
            else
            {
                Console.WriteLine("Invalid email address (missing '@' or '.').");
            }
        }
    }
}
    

