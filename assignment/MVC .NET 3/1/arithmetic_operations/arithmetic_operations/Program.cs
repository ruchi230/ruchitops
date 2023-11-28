using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            operation a1 = new operation();
            a1.add();
            Console.ReadLine();
        }
        public class operation
        {
            public void add()
            {
                Console.Write("Enter the value of a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter the value of b : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("\n--Arithmetic Operations--");
                int c = a + b;
                Console.WriteLine("\nAddition       : {0}", c);

                int d = a - b;
                Console.WriteLine("subtraction    : {0}", d);

                int e = a * b;
                Console.WriteLine("Multiplication : {0}", e);

                int f = a / b;
                Console.WriteLine("Division       : {0}", f);

                int g = a % b;
                Console.WriteLine("Modulo         : {0}", g);
            }

        }
    }
}
