using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_private_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            privatevariable obj = new privatevariable();
            obj.display();
            Console.ReadLine();
        }
        class privatevariable
        {
            private int i = 10;
            public void display()
            {
                Console.WriteLine("the value of private variable : {0}",i);
            }
        }
        
    }
}
