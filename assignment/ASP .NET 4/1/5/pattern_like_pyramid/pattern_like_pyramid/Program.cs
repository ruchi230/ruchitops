//Write a program in C# Sharp to make such a pattern like pyramid with numbers increased by 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_like_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int t = 1;

            int spc = n + 4 - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write("   ");
                }
                for (int j = 1; j <= i; j++)
                    Console.Write(" {0}   ", t++);
                Console.Write("\n");
                spc--;
            }
            Console.ReadLine();
        }
    }
}
