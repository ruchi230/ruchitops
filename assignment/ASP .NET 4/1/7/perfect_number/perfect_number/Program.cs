/*Write a C# Sharp program to check whether a given number is perfect number or not. (perfect number
is a positive integer that is equal to the sum of its proper positive divisors, that is, the sum of its positive
divisors excluding the number itself )*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.Write("The positive divisor : ");
            for (int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    Console.Write("  {0}  ",i);
                    sum = sum + i;
                }
                
            }
            Console.Write("\nThe sum of the divisor is : ");
            Console.Write("{0}", sum);

            if(sum == n)
            {
                Console.WriteLine("\nSo, the number is perfect.");
            }
            else
            {
                Console.WriteLine("\nSo, the number is not perfect.");
            }
            Console.ReadLine();
        }
    }
}
