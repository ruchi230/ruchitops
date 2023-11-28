//Create program to replace specific word from string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace_specific_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            Console.WriteLine("Initial string  : {0}", str);

            string res = str.Replace("hello", "world");
            Console.WriteLine("Replaced string : {0}", res);
            Console.ReadLine();
        }
    }
}
