//Write a program in C# Sharp to display the first n terms of Fibonacci series.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;

            Console.Write("Fibonacci series : ");
            Console.Write("  {0}  ", n1);
            Console.Write("  {0}  ", n2);

            for (int i = 2; i < n; i++)
            {
                int n3 = n1 + n2;
                Console.Write("  {0}  ", n3);
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
