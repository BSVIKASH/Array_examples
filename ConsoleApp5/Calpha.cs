using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Calpha
    {
        public void c1()
        {
            int height = 7;
            int width = 5;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    if (i == 0 || i == height - 1) 
                    {
                        if (j != 0) Console.Write("*");
                        else Console.Write(" ");
                    }
                    else if (j == 0) 
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
