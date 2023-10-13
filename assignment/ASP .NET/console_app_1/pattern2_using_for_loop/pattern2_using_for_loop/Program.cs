using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2_using_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for(int i = n; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                   Console.Write(" {0} ",i%2);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
