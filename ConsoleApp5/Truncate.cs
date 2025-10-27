using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Truncate
    {
        public void TruncateWithEllipsis()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter maximum length: ");
            int maxLength;

            if (!int.TryParse(Console.ReadLine(), out maxLength) || maxLength <= 0)
            {
                Console.WriteLine("Invalid length.");
                return;
            }

            string result;

            if (input.Length > maxLength)
            {
                
                if (maxLength <= 3)
                {
                    result = new string('.', maxLength); 
                }
                else
                {
                    result = input.Substring(0, maxLength - 3) + "...";
                }
            }
            else
            {
                result = input;
            }

            Console.WriteLine("Truncated String: " + result);
        }
    }
}
