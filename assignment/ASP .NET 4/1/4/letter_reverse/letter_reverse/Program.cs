//Write a C# Sharp program that takes three letters as input and display them in reverse order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the letter : ");
            string letter = Console.ReadLine();

            Console.Write("Enter the letter1 : ");
            string letter1 = Console.ReadLine();

            Console.Write("Enter the letter2 : ");
            string letter2 = Console.ReadLine();

            Console.WriteLine("\n--reverse order--");
            Console.WriteLine("{0} {1} {2}",letter2,letter1,letter);
            Console.ReadLine();

        }
    }
}
