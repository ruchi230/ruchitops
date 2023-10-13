/*Write a program that calculates and prints the simple interest using the
Formula: Simple Interest = PNR / 100.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of P : ");       //P=Principal amount
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of R : ");       //R=Rate of interest
            int r = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of N : ");       //N=Time period
            int n = int.Parse(Console.ReadLine());

            int i = p * r * n / 100;
            Console.WriteLine("\nSimple Interest : {0}", i);
            Console.ReadLine();
        }
    }
}
