//Write a C# Sharp program that takes 4 numbers as input to calculate and print the average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of b : ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of c : ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of d : ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double e = (a + b + c + d) / 4;
            Console.WriteLine("The average of {0},{1},{2},{3} is : {4}",a,b,c,d,e);

            Console.ReadLine();
        }
    }
}
