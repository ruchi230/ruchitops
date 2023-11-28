using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number : ");
            int n = int.Parse(Console.ReadLine());

            int n3;
            int n1 = 1;          
            Console.Write("{0} + ", n1);
            
            for (int i = 3; i <= n; i = i+2)
            {
                n3 = n1 + i;
                Console.Write("{0} + ",n3);
                n1 = n3;
            }
            Console.ReadLine();
        }
    }
}
