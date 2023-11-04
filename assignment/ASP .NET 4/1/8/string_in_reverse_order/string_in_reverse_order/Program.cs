//Write a program in C# Sharp to print a string in reverse order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string a = Console.ReadLine();

            int stringLength = a.Length;

            Console.Write("\n");

            Console.Write("Reversed string is : ");
            for (int i = stringLength - 1; i >= 0; i--)
            {
                Console.Write("{0}", a[i]);
            }
            Console.ReadLine();
        }
    }
}
