using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_and_minimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number : ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(n1>n2)
            {
                if(n1>n3)
                {
                    Console.WriteLine("n1 is maximum");
                }
                else
                {
                    Console.WriteLine("n3 is maximum");
                }
            }
            else if(n2>n3)
            {
                Console.WriteLine("n2 is maximum");
            }
            else
            {
                Console.WriteLine("n3 is maximum");
            }

            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    Console.WriteLine("n1 is minimum");
                }
                else
                {
                    Console.WriteLine("n3 is minimum");
                }
            }
            else if (n2 < n3)
            {
                Console.WriteLine("n2 is minimum");
            }
            else
            {
                Console.WriteLine("n3 is minimum");
            }
            Console.ReadLine();
        }
    }
}
