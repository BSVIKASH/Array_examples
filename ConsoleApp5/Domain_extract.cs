using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Domain_extract
    {
        public void Domain()
        {
            Console.Write("Enter email address: ");
            string email = Console.ReadLine();

            string[] parts = email.Split('@');

            if (parts.Length != 2 || parts[1].Length == 0)
            {
                Console.WriteLine("Invalid email address.");
            }
            else
            {
                Console.WriteLine("Domain: " + parts[1]);
            }
        }
    }
}
