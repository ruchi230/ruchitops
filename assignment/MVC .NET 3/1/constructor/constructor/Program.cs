using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            asc obj = new asc();
            Console.ReadLine();
        }
        public class asc
        {
            public asc()
            {
                int[] a = new int[10];
                int temp;
                Console.WriteLine("Enter the 10 numbers : ");
                for (int i = 0; i < 10; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0;i < 10; i++)
                {
                    for (int j = i+1; j < 10; j++)
                    {
                        if (a[i] > a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
                Console.Write("\nelements in ascending order : ");
                for(int i = 0; i < 10; i++)
                {
                    Console.Write(" {0} ", a[i]);
                }
            }
        }
    }
}
