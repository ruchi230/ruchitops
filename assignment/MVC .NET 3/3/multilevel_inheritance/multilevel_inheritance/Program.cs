//Write a program to implement multilevel inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.a1();
            obj.b1();
            obj.c1();
            Console.ReadLine();
        }
        public class A
        {
            public void a1()
            {
                Console.WriteLine("hello i am class A");
            }
        }
        public class B : A 
        {
            public void b1()
            {
                Console.WriteLine("hello i am class B");
            }
        }
        public class C : B
        {
            public void c1()
            {
                Console.WriteLine("hello i am class C");
            }
        }
    }
}
