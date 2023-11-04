/*Write a C# Sharp program that takes a number and a width also a number, as input and then displays
a triangle of that width, using that number.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number n : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the width w : ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= w; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("  {0}  ",n);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
