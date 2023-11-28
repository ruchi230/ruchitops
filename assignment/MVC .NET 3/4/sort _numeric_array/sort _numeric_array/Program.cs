using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort__numeric_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int temp;

            Console.Write("enter the size of an array : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements of an array : ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("\nsort numeric array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
}
