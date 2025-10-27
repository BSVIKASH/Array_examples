using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Sum_even_odd
    {
        public void sum()
        {
            Console.Write("Enter the size of the row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the size of the column: ");
            int col = Convert.ToInt32(Console.ReadLine());


            int[,] arr1 = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Enter the element: ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }



            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr1[i, j]+" ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            int odd = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr1[i,j] % 2 == 0)
                    {
                        sum = sum + arr1[i, j];
                    }
                    else
                    {
                        odd = odd + arr1[i, j];
                    }
                    
                }
                
               
            }
            Console.WriteLine("sum of the even numbers: " + sum);
            Console.WriteLine("sum of the odd numbers: " + odd);

        }
    
    }
}
