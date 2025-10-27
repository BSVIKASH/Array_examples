using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Dutch_nationalflag
    {
        public void dutch()
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
            int count = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    count++;
            }

            int[] evens = new int[count];
            int index = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    evens[index++] = num;
            }

            // ---- Step 2: Sort the even numbers (Bubble Sort) ----
            for (int i = 0; i < evens.Length - 1; i++)
            {
                for (int j = 0; j < evens.Length - i - 1; j++)
                {
                    if (evens[j] > evens[j + 1])
                    {
                        int temp = evens[j];
                        evens[j] = evens[j + 1];
                        evens[j + 1] = temp;
                    }
                }
            }

            // ---- Step 3: Put sorted even numbers back in their original even positions ----
            int evenIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] = evens[evenIndex];
                    evenIndex++;
                }
            }

            // ---- Step 4: Display the final result ----
            Console.WriteLine("After Sorting Even Numbers Only: " + string.Join(", ", arr));




        }
    }
}
