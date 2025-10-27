using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class prime
    {
        public void pr()
        {

            int[] arr1 = new int[5];

            
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
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
