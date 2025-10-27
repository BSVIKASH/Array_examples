using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class pattern6
    {
        public void pat6()
        {

            for (int i = 8; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(j + " ");
                    }
                    
                    

                }
                Console.WriteLine();
            }
        }
    }
}
