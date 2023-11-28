using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_from_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[5];
            int max;

            Console.WriteLine("Enter the five element : ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nElements of an array : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0} ",a[i]);
            }

            max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("\nmaximum elements of an array : {0}", max);
            Console.ReadLine();
        }
    }
}
