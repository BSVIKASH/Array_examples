using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Numbers_extract
    {
        public void num_extract()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("No text entered.");
                return;
            }

            List<string> numbers = new List<string>();
            StringBuilder currentNumber = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    currentNumber.Append(c);
                }
                else
                {
                    if (currentNumber.Length > 0)
                    {
                        numbers.Add(currentNumber.ToString());
                        currentNumber.Clear();
                    }
                }
            }

           
            if (currentNumber.Length > 0)
                numbers.Add(currentNumber.ToString());

            if (numbers.Count > 0)
            {
                Console.WriteLine("Numbers found:");
                foreach (string num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("No numbers found.");
            }
        }
    }
    
}
