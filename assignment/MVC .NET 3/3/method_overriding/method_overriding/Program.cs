using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1.a1();
            B obj2 = new B();
            obj2.a1();
            Console.ReadLine();
        }
        public class A
        {
            public virtual void a1()
            {
                Console.WriteLine("Parent class ");
            }              
        }
        public class B : A
        {
            public override void a1()
            {
                Console.WriteLine("Child class ");
            }
        }

    }
}
