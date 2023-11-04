//Write a program in C# to display the sum of the series [ 9 + 99 + 999 + 9999 ...]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_the_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Display the sum of the series [ 9 + 99 + 999 + 9999 ...]");
            Console.WriteLine("--------------------------------------------------------");

            Console.Write("Input the number of terms : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int t = 9;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + t;
                Console.Write("{0}   ",t);
                t = t*10+9;
            }
            Console.WriteLine("\nThe sum of the series : {0}",sum);
            Console.ReadLine();
        }
    }
}
