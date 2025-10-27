using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class str1
    {
        public void string1()
        {

            //string sentence = "My name is Vikash,I am from Dindigul,I am working as an intern at ups.";

            //string[] arr1 = sentence.Split(",");
            //foreach (string s in arr1)
            //{
            //    Console.WriteLine(s);
            //}

            //string mailId = "bsvikash137@gmail.com";

            //Console.WriteLine(mailId.Substring(0, 11));

            //string file1 = "text string.txt";

            //Console.WriteLine(file1.Replace(" ", "_"));

            //string name = "bsvikash137@yahoo.com";
            //bool n = name.Contains("@gmail.com");
            //bool s = name.Contains("@yahoo.com");
            //bool v = name.Contains("@outlook.com");

            //if (n is true)
            //{
            //    Console.WriteLine("Gmail.account");
            //}
            //else if(s is true)
            //{
            //    Console.WriteLine("Yahoo account");
            //}
            //else if(v is true)
            //{
            //    Console.WriteLine("Windows outlook account");
            //}


            //string[] arr1 = { "bsvikash137@gmail.com", "992200040249@gmail.com", "vikash4536@gmmail.com" } ;

            //Console.WriteLine(string.Join(";", arr1));

            //string name1 = "Vikash";
            //string name2 = string.Copy(name1);
            //Console.WriteLine(name2);
            //string mailId = "bsvikash137@gmail.com";
            //int count = 0;
            //foreach(char i  in  mailId){
            //    if(i >= '0' && i <= '9')
            //    {
            //        count++;
            //    }


            //}



            //foreach (char i in mailId)
            //{
            //    bool v = char.IsLetterOrDigit(i);

            //    if (v is not true)
            //    {
            //        count++;
            //    }



            //}
            //Console.WriteLine(count);

            string para = "Hello I am Vikash and I am doing my intern at UPS Chennai.I am a passionate student who works hard and dedicate myself for the work.I have worked on several ml projects";
            string[] arr1 = para.Split(".");
            int Count = 0;
            foreach (string s in arr1)
            {
                Count++;
            }

            string[] arr2 = para.Split(" ");
            int Count2 = 0;
            foreach (string s in arr2)
            {
                Count2++;
            }


            Console.WriteLine("no of sentences: " + Count);
            Console.WriteLine("no of words: " + Count2);




        }
    }
}
