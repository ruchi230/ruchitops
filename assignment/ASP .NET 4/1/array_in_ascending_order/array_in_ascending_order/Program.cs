// Write a program in C# Sharp to sort elements of array in ascending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_in_ascending_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i;
            int j;
            int tmp;

            Console.Write("Input the size of array : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.ReadLine();
        }
    }
}
