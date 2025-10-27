using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class arr_task4
    {
        public void t4()
        {
            int[,] arr1 = new int[4, 3];

            Console.WriteLine("-----4 x 3 array----");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter the element: ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("ARRAY");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Enter the number to be searched: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for(int i = 0; i< 4; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    if (arr1[i, j] == num)
                    {
                        Console.WriteLine($"Number {num} found at position ({i}, {j})");
                        found = true;
                    }
                }
            }
        }
    }
}
