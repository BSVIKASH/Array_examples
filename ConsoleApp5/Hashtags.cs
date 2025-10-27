using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Hashtags
    {
        public void hashtags()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("No sentence entered.");
                return;
            }

            List<string> hashtags = new List<string>();
            string[] words = sentence.Split(' '); // split by spaces

            foreach (string word in words)
            {
                if (word.StartsWith("#") && word.Length > 1)
                {
                    hashtags.Add(word);
                }
            }

            if (hashtags.Count > 0)
            {
                Console.WriteLine("Hashtags found:");
                foreach (string tag in hashtags)
                {
                    Console.WriteLine(tag);
                }
            }
            else
            {
                Console.WriteLine("No hashtags found.");
            }
        }
    }
    
}
