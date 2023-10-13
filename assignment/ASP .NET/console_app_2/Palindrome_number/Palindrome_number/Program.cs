//Write a program for check given number is Palindrome or not

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

            int original = n;

            int remainder ;
            int reverse = 0;

            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n = n/10;
            }

            if (original == reverse)
            {
                Console.WriteLine("\n{0} is a palindrome",original);
            }
            else
            {
                Console.WriteLine("\n{0} is not a palindrome", original);
            }
            
            Console.ReadLine();
        }
    }
}
