using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class arr_task2
    {
        public void t2()
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
            for (int i = 0; i < 4; i++)
            {
                int sum1 = 0;
                for (int j = 0; j < 3; j++)
                {
                    
                    
                        sum1 = sum1 + arr1[i, j];
                    
                }
                Console.WriteLine($"sum of the numbers in row {i}: " + sum1);
                
            }
        }
    }
    
}
