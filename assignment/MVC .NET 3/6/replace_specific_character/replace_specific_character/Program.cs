//Create program to replace specific character from string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace_specific_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello korld";
            Console.WriteLine("Initial string  : {0}",str);

            string res = str.Replace('k', 'w');
            Console.WriteLine("Replaced string : {0}", res);
            Console.ReadLine();
        }
    }
}
