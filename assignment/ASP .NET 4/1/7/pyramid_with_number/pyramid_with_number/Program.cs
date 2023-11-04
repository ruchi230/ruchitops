/*Write a program in C# Sharp to make such a pattern like pyramid with number which will repeat the
number in a same row.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid_with_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number of rows : ");
            int n = int.Parse(Console.ReadLine());
            int t = 1;
            Console.WriteLine("\n");

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
