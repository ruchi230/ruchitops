//Write a C# Sharp program to find out the sum of in A.P. Series.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_progress_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the starting number of the A.P. series: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Input the number of items for the A.P. series: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Input the common difference of A.P. series: ");
            int n3 = int.Parse(Console.ReadLine());

            int s = 0;
            int ln;            
            ln = n1 + (n2 - 1) * n3;

            Console.WriteLine("The Sum of the A.P. series are:");
            for (int i = n1; i <= ln; i = i+n3)
            {
                if(i != ln)
                {
                    Console.Write("{0} + ",i);
                }
                else
                {
                    Console.Write("{0}  ", i);
                }
                s = s + i;
            }
            Console.WriteLine("= {0}", s);
            Console.ReadLine();
        }
    }
}
