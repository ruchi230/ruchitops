//Write a C# Sharp program to find the largest of three numbers.

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_of_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number a : ");
            int a  = int.Parse(Console.ReadLine());

            Console.Write("Enter the number b : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the number c : ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The 1st Number is the greatest among three");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest among three");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
            Console.ReadLine();
        }
    }
}
