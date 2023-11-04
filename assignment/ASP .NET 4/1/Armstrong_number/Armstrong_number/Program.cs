/*Write a C# Sharp program to check whether a given number is Armstrong number or not.(An
Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the
number itself. )*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int temp;
            int r;
            int sum = 0;

            for(temp = n; n != 0; n = n /10)
            {
                r = n % 10;
                sum = sum + (r*r*r);
            }
            if (sum == temp)
            {
                Console.WriteLine("{0} is an Armstrong number.",temp);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", temp);
            }
            Console.ReadLine();
        }
    }
}
