using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class String_digits
    {
        public void str_digits()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool onlyDigits = true;

            // Check each character manually
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < '0' || input[i] > '9')
                {
                    onlyDigits = false;
                    break;
                }
            }

            if (onlyDigits && input.Length > 0)
                Console.WriteLine("✅ The string contains only digits.");
            else
                Console.WriteLine("❌ The string does not contain only digits.");
        }
    }
    
}
