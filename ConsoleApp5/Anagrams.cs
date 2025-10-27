using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Anagrams
    {
        public void anagram1()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            
            str1 = new string(str1.ToLower().Where(c => !Char.IsWhiteSpace(c)).ToArray());
            str2 = new string(str2.ToLower().Where(c => !Char.IsWhiteSpace(c)).ToArray());

            
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("\n❌ The strings are NOT anagrams (different lengths).");
                return;
            }

            
            string sorted1 = String.Concat(str1.OrderBy(c => c));
            string sorted2 = String.Concat(str2.OrderBy(c => c));

            
            if (sorted1 == sorted2)
            {
                Console.WriteLine("\nThe strings are ANAGRAMS!");
            }
            else
            {
                Console.WriteLine("\nThe strings are NOT anagrams.");
            }

           

        }
    }
}
