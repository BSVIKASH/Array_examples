using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class arr_task1
    {
        public void t1()
        {

            int[,] arr1 = new int[3, 3];

            Console.WriteLine("-----3 x 3 array----");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter the element: ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }



            }
            Console.WriteLine("ARRAY");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
