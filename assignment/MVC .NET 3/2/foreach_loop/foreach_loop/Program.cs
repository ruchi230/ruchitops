//Create program to iterate string variable using foreach loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter string : ");
            string a = Console.ReadLine();
            Console.WriteLine("\n--iterate string variable--");

            foreach (char s in a)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadLine();
        }
    }
}
