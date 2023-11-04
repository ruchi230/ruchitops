//Write a C# program to display alphabet pattern like I with asterisk.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_like_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");

            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    if(j == 3 || (i == 0 && j > 0 && j < 6) || (i == 6 && j > 0 && j < 6))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
