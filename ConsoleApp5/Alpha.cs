using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Alpha
    {
        public void al()
        {
            int height = 7; 
            int width = (height / 2) + 1;
            int mid = height / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= width; j++)
                {
                   
                    if ((j == 0 || j == width) && i != 0 ||   
                        i == 0 && j != 0 && j != width ||     
                        i == mid)                             
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
