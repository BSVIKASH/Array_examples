using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class prime2
    {
        public void pr2()
        {
            int[,] arr1 = new int[4, 2];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter the element: ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }



            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n----Prime number check----");

            foreach (int num in arr1)
            {
                bool isPrime = true;

                if (num <= 1)
                    isPrime = false;
                else
                {
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                    Console.WriteLine($"{num} is Prime");
                else
                    Console.WriteLine($"{num} is Not Prime");
            }
        }
    }
    
}
