//Write a C# Sharp program to calculate what day of the week is 40 days from this moment.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_of_the_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(40);
            Console.WriteLine("Today: {0:dddd}", today);
            Console.WriteLine("40 days from today: {0:dddd}", answer);
            Console.ReadLine();
        }
    }
}
