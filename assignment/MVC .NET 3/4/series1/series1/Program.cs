using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

            int n3;
            int n1 = 0;
            int n2 = 1;
            Console.Write("{0} + ", n2);

            for (int i = 2; i <= n; i++)
            {
                n3 = n1 + n2;
                Console.Write("{0} + ", n3);
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
