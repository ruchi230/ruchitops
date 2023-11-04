/*Write a program in C# Sharp to make such a pattern like right angle triangle with number
increased by 1.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_angle_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int a = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" {0} ",a);
                    a++;
                }
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
