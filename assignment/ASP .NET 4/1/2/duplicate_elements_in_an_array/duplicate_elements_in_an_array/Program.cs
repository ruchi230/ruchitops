//Write a program in C# to count total number of duplicate elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int m = 1;
            int ctr = 0;

            Console.Write("Input the number of elements to be stores in the array : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            
            for(int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = m;
                        m++;
                    }
                }
                m = 1;
            }

            for( int i = 0; i < n;i++)
            {
                if (arr3[i] == 2)
                {
                    ctr++;
                }
            }
            Console.WriteLine("The number of duplicate elements found in the array is : {0} ", ctr);
            Console.ReadLine();

        }
    }
}
