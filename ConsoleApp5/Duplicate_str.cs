using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Duplicate_str
    {
        public void dup()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();


            str = str.ToLower();


            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length-1; i++)
            {

                if (chars[i] == chars[i + 1])
                {
                    Console.WriteLine("Duplicate value: " + chars[i]);
                }
                
            }
        }
    }
}
