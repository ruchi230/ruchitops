/*Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the
total, percentage and division.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the roll number a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the name b : ");
            string b = Console.ReadLine();

            Console.Write("Enter marks in physics p : ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter marks in chemistry c : ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter marks in computer application n : ");
            int n = int.Parse(Console.ReadLine());

            int d = p + c + n;
            int e = d / 3;

            Console.WriteLine("\n--Student Detail--");
            Console.WriteLine("The Rollnumber             : {0}", a);
            Console.WriteLine("The Student name           : {0}", b);
            Console.WriteLine("Physics marks              : {0}", p);
            Console.WriteLine("Chemistry marks            : {0}", c);
            Console.WriteLine("Computer application marks : {0}", n);
            Console.WriteLine("Total Marks                : {0}", d);
            Console.WriteLine("Percentage                 : {0}", e);

            if(e >= 80)
            {
                Console.WriteLine("Division                   :First Class");
            }
            else if(e >= 60 && e <80)
            {
                Console.WriteLine("Division                   :Second Class");
            }
            else 
            {
                Console.WriteLine("Division                   :Pass");
            }
            Console.ReadLine();
        }
    }
}
