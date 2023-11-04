//Write a C# Sharp program to swap two numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of b : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\t--before swapping--");
            Console.WriteLine("\t\ta is : {0}", a);
            Console.WriteLine("\t\tb is : {0}\n", b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("\t--after swapping--");
            Console.WriteLine("\t\ta is : {0}", a);
            Console.WriteLine("\t\tb is : {0}", b);
            Console.ReadLine();
        }
    }
}
