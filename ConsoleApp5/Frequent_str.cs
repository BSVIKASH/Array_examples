using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Frequent_str
    {
        public void fre()
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            char ch = ' ';
            int maxcount = 0;
            
            for(int i = 0; i<str.Length; i++)
            {
                int count = 0;
                for(int j =0;j<str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;

                    }
                }
                if (maxcount < count)
                {
                    maxcount = count;
                    ch = str[i];
                }

            }
            Console.WriteLine("Frequent chracter : " + ch);
            Console.WriteLine("No of times the character repeats: " + maxcount);


        }
    }
}
