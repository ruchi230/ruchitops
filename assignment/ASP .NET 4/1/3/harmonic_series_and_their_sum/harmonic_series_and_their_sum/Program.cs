//Write a program in C# Sharp to display the n terms of harmonic series and their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmonic_series_and_their_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms : ");
            int n = int.Parse(Console.ReadLine());
            double s = 0.0;
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ",i);
                s = s + 1/(float)i;
            }
            Console.WriteLine("\nSum of Series : {0}", s);
            Console.ReadLine();
            

        }
    }
}
