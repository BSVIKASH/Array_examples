using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class reverse_string
    {
        public void reverse()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            
            char[] chars = str.ToCharArray();

            Console.WriteLine("\nReversed string:");

            
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }

            Console.WriteLine();


        }
    }
}
