using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Mask_card
    {
        public void card()
        {
            Console.Write("Enter credit card number: ");
            string cardNumber = Console.ReadLine();

            


           
            int totalDigits = 0;
            foreach (char c in cardNumber)
                if (c >= '0' && c <= '9') totalDigits++;

            if (totalDigits == 0)
            {
                Console.WriteLine ( cardNumber); 
            }
            int digitsToKeep = 4;
            int toMask = Math.Max(0, totalDigits - digitsToKeep);
            StringBuilder masked = new StringBuilder();

            foreach (char c in cardNumber)
            {
                if (c >= '0' && c <= '9')
                {
                    if (toMask > 0)
                    {
                        masked.Append('*');
                        toMask--;
                    }
                    else
                    {
                        masked.Append(c); 
                    }
                }
                else
                {
                    masked.Append(c); 
                }
            }

            Console.WriteLine(masked.ToString());
        }
    }
    
}
