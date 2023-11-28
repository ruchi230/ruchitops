/*Write a program to calculate factorial number of user defined
value using class.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            factorial obj = new factorial();
            obj.number();
            Console.ReadLine();
        }
        public class factorial
        {
            public void number()
            {
                Console.Write("Enter the number : ");
                int n = int.Parse(Console.ReadLine());
                int f = 1;

                Console.WriteLine();
                for (int i = n; i >= 1; i--)
                {
                    f = f * i;
                    Console.Write("{0} * ", i);
                }
                Console.WriteLine("\nThe Factorial of {0} is : {1}",n,f);
            }
        }
    }
}
