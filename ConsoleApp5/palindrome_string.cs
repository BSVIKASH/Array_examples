using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class palindrome_string
    {
        public void palindrome()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

           
            str = str.ToLower();

            
            char[] chars = str.ToCharArray();

            
            Array.Reverse(chars);

            
            string reversed = new string(chars);

            
            if (str == reversed)
                Console.WriteLine($"{str} is a Palindrome");
            else
                Console.WriteLine($"{str} is Not a Palindrome");
        }


    }
    }

