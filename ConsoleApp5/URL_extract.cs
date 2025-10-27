using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class URL_extract
    {
        public void extract()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("No text entered.");
                return;
            }

            List<string> urls = new List<string>();
            string[] words = text.Split(' '); // split by spaces

            foreach (string word in words)
            {
                // Simple check for URLs starting with http:// or https://
                if (word.StartsWith("http://") || word.StartsWith("https://"))
                {
                    // Remove trailing punctuation if any
                    string url = word.TrimEnd('.', ',', ';', '!', '?');
                    urls.Add(url);
                }
            }

            if (urls.Count > 0)
            {
                Console.WriteLine("URLs found:");
                foreach (string url in urls)
                {
                    Console.WriteLine(url);
                }
            }
            else
            {
                Console.WriteLine("No URLs found.");
            }
        }
    }
    }
}
