using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            demo obj = new demo();
            obj.A();
            Console.ReadLine();
        }
        public class demo
        {
            public void A()
            {
                Console.WriteLine("Hello i am class demo");
            }
        }
    }
}
