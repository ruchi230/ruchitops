using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int c;

            for (int i = 1; i <= n; i++)

            {
                c = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i%j == 0)
                        Console.WriteLine("i%j = {0}",i%j);
                    {
                        c++;
                        Console.WriteLine("c = {0}", c);
                    }
                        
                }
               
                if(c== 2)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
