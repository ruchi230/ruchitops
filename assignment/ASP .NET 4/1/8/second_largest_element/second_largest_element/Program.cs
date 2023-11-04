//Write a program in C# Sharp to find the second largest element in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[50];
            int i;
            int lrg;
            int j = 0;
            int lrg2;

            Console.Write("Input the size of array : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            lrg = 0;

            for (i = 0; i < n; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }

            lrg2 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (lrg2 < arr1[i])
                    {
                        lrg2 = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2);
            Console.ReadLine();
        }
    }
}
