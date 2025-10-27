using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Phone_validate
    {
        public void phonevalidate()
        {
            Console.Write("Enter the phone number:");
            string phone = Console.ReadLine();

            bool isValid = true;
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < '0' || phone[i] > '9')
                {
                    isValid = false;
                    break;
                }
            }

            if(  isValid && phone.Length == 10)
            {
                Console.WriteLine("Valid phone number.");


            }
            else
            {
                Console.WriteLine("Invalid phone number.");
            }


        }
    }
}
