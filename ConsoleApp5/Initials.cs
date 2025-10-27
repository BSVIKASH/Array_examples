using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Initials
    {
        public void Initial()
        {
            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("No name entered.");
                return;
            }

            string[] words = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string initials = "";

            foreach (string word in words)
            {
                initials += char.ToUpper(word[0]);
            }

            Console.WriteLine("Initials: " + initials);
        }
    }
}
