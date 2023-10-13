//Write a program for check Given no is Armstrong or not

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

            int original = n;

            int remainder;
            int sum=0;

            while (n != 0)
            {
                remainder = n % 10;
                sum = sum +(remainder * remainder * remainder);
                n = n/10;
            }

            if(original == sum)
            {
                Console.WriteLine("\n{0} is armstrong number",original);
            }
            else
            {
                Console.WriteLine("\n{0} is not armstrong number",original);
            }
            Console.ReadLine();
        }
    }
}
