/*Write a C# Sharp program to print on screen the output of adding,
Subtracting, multiplying and dividing of two numbers which will entered by the user.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;

            Console.WriteLine("  {0} + {1} = {2}", a, b, c);
            Console.WriteLine("  {0} - {1} = {2}", a, b, d);
            Console.WriteLine("  {0} * {1} = {2}", a, b, e);
            Console.WriteLine("  {0} / {1} = {2}", a, b, f);
            Console.WriteLine("  {0} mod {1} = {2}", a, b, g);
            Console.ReadLine();
        }
    }
}
