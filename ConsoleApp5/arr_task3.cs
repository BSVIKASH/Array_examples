using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class arr_task3
    {
        public void t3()
        {
            int rows = 3;
            int cols = 4;
            int[,] arr = new int[rows, cols];

            
            Console.WriteLine("Enter 12 elements for a 3x4 array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("ARRAY");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nSum of each column:");
            for (int j = 0; j < cols; j++)
            {
                int colSum = 0;
                for (int i = 0; i < rows; i++)
                {
                    colSum += arr[i, j];
                }
                Console.WriteLine($"Column {j + 1}: {colSum}");
            }

        }

    }
}
