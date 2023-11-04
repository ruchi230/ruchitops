//Write a program in C# Sharp to print the Floyd's Triangle

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floyd_s_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int p;
            int q;
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    p = 1;
                    q = 0;
                }
                else
                {
                    p = 0;
                    q = 1;
                }
                for (int j = 1; j <= i; j++)
                {
                    if(j % 2 == 0)
                    {
                        Console.Write("  {0}  ",p);
                    }
                    else
                    {
                        Console.Write("  {0}  ",q);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
