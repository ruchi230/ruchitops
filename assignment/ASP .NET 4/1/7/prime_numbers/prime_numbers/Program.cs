/*Write a program in C# Sharp to find the prime numbers within a range of numbers. (A Prime Number
can be divided evenly only by 1 )*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int c;
            Console.Write("The prime number between 1 and {0} are :", n);
            for (int i = 1; i <= n; i++)
            {
                c = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)                        
                    {
                        c++;
                        
                    }
                }
                
                if (c == 2)
                {
                    Console.Write("\n{0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
