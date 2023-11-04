//Write a C# Sharp program that takes a number as input and print its multiplication table.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("  {0}  {1}  {2}",a,i,a*i);
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
