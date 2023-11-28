using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {                    
                        Console.Write(" {0} ",i);   
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
