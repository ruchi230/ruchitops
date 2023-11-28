using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal obj1 = new animal();
            obj1.makesound();
            cat obj = new cat();
            obj.makesound();
 
            Console.ReadLine();
        }
        public class animal
        {
            public virtual void makesound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }
        public class cat : animal
        {
            public override void makesound()
            {
                Console.WriteLine("The cat meows");
            }
        }
    }
}
