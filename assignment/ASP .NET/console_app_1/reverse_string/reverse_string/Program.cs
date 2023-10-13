//Write a Program that reverses the entered string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string a = Console.ReadLine();

            int stringLength = a.Length;

            Console.Write("\n");

            for (int i = stringLength-1; i >= 0; i--)
            {
                Console.Write("{0}", a[i]);
            }
            Console.ReadLine();
        }
    }
}
