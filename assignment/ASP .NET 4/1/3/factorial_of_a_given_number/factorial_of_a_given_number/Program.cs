//Write a C# Sharp program to calculate the factorial of a given number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_of_a_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;

            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }
            Console.WriteLine("\nThe Factorial of {0} is : {1}",n,a);
            Console.ReadLine();
        }
    }
}
