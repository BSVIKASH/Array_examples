using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Insertion
    {
        public void insert()
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

            for(int i = 1; i < n ; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j >=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            Console.WriteLine(String.Join(",", arr));
        }
    }
}
