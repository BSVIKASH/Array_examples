using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Vowels_str
    {
        public void vovwels()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();


            str = str.ToLower();


            char[] chars = str.ToCharArray();
            int Count = 0;
            for(int i = 0; i<chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
    }
}
