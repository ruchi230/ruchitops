/*Create program to take 2 numbers from user and show
maximum number*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the first number n1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("enter the second number n2: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1>n2)
            {
                Console.WriteLine("\nn1 is maximum");
            }
            else
            {
                Console.WriteLine("\nn2 is maximum");
            }
            Console.ReadLine();
        }
    }
}
