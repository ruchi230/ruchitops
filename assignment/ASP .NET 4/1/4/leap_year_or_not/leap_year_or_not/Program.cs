//Write a C# Sharp program to find whether a given year is leap year or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year n : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if((n % 4 == 0) && (n % 400 == 0) || (n % 100 != 0))
            {
                Console.WriteLine("{0} is a leap year", n);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", n);
            }
            Console.ReadLine();
        }
    }
}
