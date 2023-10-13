//Write a program using do…..while loop to calculate and print the Fibonacci numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N : ");
            int num = int.Parse(Console.ReadLine());

            int n3;
            int n1 = 0;
            int n2 = 1;

            Console.WriteLine("\n--Fibonacci numbers--");
            Console.Write("\n  {0}  ", n1);
            Console.Write("  {0}  ", n2);

            int i = 2;
            do
            {
                n3 = n1 + n2;
                Console.Write("  {0}  ",n3);
                n1 = n2;
                n2 = n3;
                i++;
            }while(i < num);

            Console.ReadLine();
        }
    }
}
