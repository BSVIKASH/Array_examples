using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class selection_sort
    {
        public void select()
        {
            Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the value: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(string.Join(",", arr));

            for(int i = 0; i < n - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
