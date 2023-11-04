//Write a program in C# Sharp to display the multiplication table vertically from 1 to n.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table_vertically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} * {1} = {2}, ", j, i, i * j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
