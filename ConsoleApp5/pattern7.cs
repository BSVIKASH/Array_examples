using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class pattern7
    {
        public void pat7()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write( "1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }



                }
                Console.WriteLine();
            }
        }
    }
}
