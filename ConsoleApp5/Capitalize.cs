using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Capitalize
    {
        public void cap()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string[] arr = str.Split(".");

            foreach (string i in arr)
            {
                i.ToUpper();


            }

            //    for (int i = 0; i< chars.Length - 1; i++)
            //{
            //    char.ToUpper(chars[i]);
            //    Console.Write(chars[i]);
            //}
            //Console.WriteLine();
        }
    }
}
