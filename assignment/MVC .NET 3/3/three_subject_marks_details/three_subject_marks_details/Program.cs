/*Write a program to get three subject marks details and then
show average and sum.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_subject_marks_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            subject obj = new subject();
            obj.marks();
            Console.ReadLine();
        }
        public class subject
        {
            public void marks()
            {
                Console.Write("Enter the marks of maths : ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the marks of English : ");
                int n2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the marks of Science : ");
                int n3 = int.Parse(Console.ReadLine());

                Console.WriteLine("\n--Student Marks Details--");
                Console.WriteLine("\nmarks in Maths   : {0}",n1);
                Console.WriteLine("marks in English : {0}", n2);
                Console.WriteLine("marks in Science : {0}", n3);

                int a = (n1 + n2 + n3) / 3;
                Console.WriteLine("Average marks of 3 subject : {0}",a);

                int s = n1 + n2 + n3;
                Console.WriteLine("Sum of 3 subject marks : {0}", s);
            }
        }
    }
}
