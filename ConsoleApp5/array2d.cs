using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class array2d
    {
        public void array2()
        {
            Console.Write("Enter the size of the row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the size of the column: ");
            int col = Convert.ToInt32(Console.ReadLine());


            int[,] arr1 = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write("Enter the element: ");
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine()) ;
                }
                
                

            }

            for (int i = 0; i<row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(arr1[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }

}
