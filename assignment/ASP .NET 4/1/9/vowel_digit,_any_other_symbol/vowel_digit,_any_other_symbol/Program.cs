/*Write a C# Sharp program that takes a character as input and check the input (lowercase) is vowel, a
digit, or any other symbol.*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_digit__any_other_symbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input character n : ");
            char n = char.Parse(Console.ReadLine());
            Console.WriteLine();
            

            if ((n == 'a') || (n == 'e') || (n == 'i') || (n == 'o') || (n == 'u')) 
            {
                Console.WriteLine("{0} is lowercase vowel",n);
            }
            else if((n >= '0') && (n <= '9'))
            {
                Console.WriteLine("{0} is digit",n);
            }
            else
            { 
                Console.WriteLine("{0} is another symbol", n);
            }
            Console.ReadLine();
        }
    }
}
