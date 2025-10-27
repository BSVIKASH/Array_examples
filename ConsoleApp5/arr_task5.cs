using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class arr_task5
    {
        public void t5()
        {
            int[,] arr1 = new int[4, 3];
            int[,] arr2 = new int[4, 3];

            Console.WriteLine("-----4 x 3 array----");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter the element: ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }



            }

            Console.WriteLine("ARRAY 1");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter the element: ");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }



            }

            Console.WriteLine("ARRAY 2");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] sum = new int[4, 3];

            Console.WriteLine("SUM OF THE ARRAYS");
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    sum[i, j] = arr1[i, j] + arr2[i, j];
                    Console.Write(sum[i, j] + " ");

                }
                Console.WriteLine();

            }
        }
    }
}
