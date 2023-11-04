//Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[200];
            int n3;
            int i;
            int j;
            int k;

            Console.Write("Input the number of elements to be stored in the first array :");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n1);
            for (i = 0; i < n1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Input the number of elements to be stored in the second array :");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n2);
            for ( i = 0; i < n2; i++)
            {
                Console.Write("element - {0} : ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            n3 = n1 + n2;
            for (i = 0; i < n1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < n2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }

            for (i = 0; i < n3; i++)
            {
                for (k = 0; k < n3 - 1; k++)
                {

                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }
            Console.Write("\nThe merged array in ascending order is :\n");
            for (i = 0; i < n3; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.ReadLine();
        }
    }
}
