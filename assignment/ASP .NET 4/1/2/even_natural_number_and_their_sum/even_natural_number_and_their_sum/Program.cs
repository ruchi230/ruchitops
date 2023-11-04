//Write a program in C# Sharp to display the n terms of even natural number and their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_natural_number_and_their_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine("--The even numbers Are--");
            for (int i = 2; i <= n; i=i+2)
            {
                Console.Write(" {0} ",i);
                sum = sum + i;  
            }
            
            Console.WriteLine("\nThe Sum of even Natural Numbers are : {0}", sum); 
            Console.ReadLine();
        }
    }
}
