//Write a program in C# Sharp to delete an element at desired position from an array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete_an_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[50];
            int i;

            Console.Write("Input the size of array : ");
            int n = int.Parse(Console.ReadLine());  

            Console.Write("Input {0} elements in the array:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete: ");
            int p = int.Parse(Console.ReadLine());

            i = 0;
            while (i != p - 1)
            {
                i++;
            }               

            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;

            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.ReadLine();
        }
    }
}
