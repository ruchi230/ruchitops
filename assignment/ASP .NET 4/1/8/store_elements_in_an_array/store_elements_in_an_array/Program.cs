//Write a program in C# Sharp to store elements in an array and print it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            Console.Write("Input 10 elements in the Array :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nelement - {0} : ",i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nElements in array are : ");
            for (int i = 0;i < 10; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
}
