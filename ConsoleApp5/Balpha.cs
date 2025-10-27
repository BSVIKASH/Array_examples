using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Balpha
    {
        public void b1()
        {
            int height = 7;
            int width = 5;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    if (j == 0 ||                                   
                        (i == 0 || i == height - 1 || i == height / 2) && j < width - 1 ||  
                        j == width - 1 && i != 0 && i != height - 1 && i != height / 2)     
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
