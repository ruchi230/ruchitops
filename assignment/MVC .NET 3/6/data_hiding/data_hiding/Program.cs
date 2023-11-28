//Write a program to perform an example of data hiding.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_hiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mystudent obj = new mystudent();
            obj.member();
            Console.ReadLine();
        }
        public class myclass
        {
            public void member()
            {
                Console.WriteLine("total number of students : 3");
            }
        }
        public class mystudent : myclass 
        {
            public new void member()
            {
                Console.WriteLine("Name : Ruchi,Marks : 40\nName : Shivanee,Marks : 45\nName : Ria,Marks : 49");
            }
        }

        
    }
}
