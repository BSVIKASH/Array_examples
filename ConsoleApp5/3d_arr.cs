using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class _3d_arr
    {
        public void t6()
        {
            Console.WriteLine("-----3D array----");
            int[,,] arr = new int[2, 2, 2];
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k=0; k < 2; k++)
                    {
                        Console.Write("Enter the element: ");
                        arr[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }

                }
            }

            for( int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {

                    }
                }
            }
        }
    }
}
