using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class pattern9
    {
        public void pat9()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    if(i == 1 || j == 1 || i == 5 || j == 5 || i == j)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
