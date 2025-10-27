using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class pattern1
    {
        public void pat1()
        {
            int count = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    count++;
                    Console.Write(count+" ");
                }
                Console.WriteLine();

            }
        }
    }
}
