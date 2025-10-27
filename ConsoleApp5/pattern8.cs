using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class pattern8
    {
        public void pat8()
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if(i == 1 || j==1 || i == 4 || j == 4)
                    {
                        Console.Write(j+" "); 
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
