//Write a program to call method of parent class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_parent_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            call obj = new call();
            obj.a();
            Console.ReadLine();
        }
        public class call
        {
            public void a()
            {
                Console.WriteLine("Hello i am Parent Class");
            }
        }
    }
}
