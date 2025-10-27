using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class pattern5
    {
        public void pat5()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for(int k = 1; k <= n - 1; k++)
                {
                    Console.WriteLine(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }
}
