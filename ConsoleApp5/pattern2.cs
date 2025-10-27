using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class pattern2
    {
        public void pat2()
        {
            char A = 'A';
            for (int i = 1; i <= 4; i++)
            {
                for(int j= 1; j <= 4; j++)
                {
                    
                    Console.Write(A + " ");
                    A++;
                }
                Console.WriteLine();
            }
        }
    }
}
