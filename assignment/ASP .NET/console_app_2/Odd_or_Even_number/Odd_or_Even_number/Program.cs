//Write a program for Check Given number is Odd or Even

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

            if(n % 2 ==0)
            {
                Console.WriteLine("\n{0} is Even number",n);
            }
            else
            {
                Console.WriteLine("\n{0} is odd number",n);
            }
            Console.ReadLine();
        }
    }
}
