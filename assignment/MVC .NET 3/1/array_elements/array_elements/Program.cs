/*Get 5 values from user and store in array and show all elements
and sum of elements*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 0;

            Console.WriteLine("Enter the 5 element : ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("elements of an array : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" {0} ",a[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                sum = sum + a[i]++;
            }
            Console.WriteLine("\nsum of elements : {0}", sum);
           
            Console.ReadLine();
        }
    }
}
