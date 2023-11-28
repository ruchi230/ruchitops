using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int n3 = 0;
            int n1 = 0;

            for (int i = 1; i <= n; i++)
            {
                n1 = n1+(i * i);
                int n2 = n3 + n1;
                Console.Write(" {0} + ",n2);                
            }
            n3 = n1;
            Console.ReadLine();
        }
    }
}
