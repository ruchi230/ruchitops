using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace static_method
{
    internal class Program
    {
        static int x = 7;
        static int y = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("addition of x and y: {0}",Program.x+y);
            
            Console.ReadLine();
        }
        
    }
}
