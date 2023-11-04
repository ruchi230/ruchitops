//Write a program in C# Sharp to find the second smallest element in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_smallest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[50];
            int i;
            int sml;
            int j = 0;
            int sml2;

            Console.Write("Input the size of array : ");
            int n = int.Parse(Console.ReadLine());  

            Console.Write("Input {0} elements in the array (value must be <9999):\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            sml = 0;
            for (i = 0; i < n; i++)
            {
                if (sml > arr1[i])
                {
                    sml = arr1[i];
                    j = i;
                }
            }

            sml2 = 99999;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* ignoring the smallest element */
                    i--;
                }
                else
                {
                    if (sml2 > arr1[i])
                    {
                        sml2 = arr1[i];
                    }
                }
            }

            Console.Write("The Second smallest element in the array is :  {0} \n\n", sml2);
            Console.ReadLine();
        }
    }
}
