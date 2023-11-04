//Write a program in C# Sharp which is a Menu Driven Program to perform a simple calculation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Menu driven program for a simple calculator---\n");

            Console.Write("Enter first integer : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHere are the options");
            Console.WriteLine("1-Addition.\n2-Subtraction.\n3-Multiplication.\n4-Division.\n");
            Console.Write("Input your choice : ");
            int n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 1:
                    Console.WriteLine("The Addition of {0} and {1} is  : {2} ", a, b, a + b);
                    break;
                case 2:
                    Console.WriteLine("The Subtraction of {0} and {1} is : {2} ", a, b, a - b);
                    break;
                case 3:
                    Console.WriteLine("The Multiplication of {0} and {1} is : {2} ", a, b, a * b);
                    break;
                case 4:
                    if(b == 0)
                    {
                        Console.WriteLine("The second integer is Zero");
                    }
                    else
                    {
                        Console.WriteLine("The Division of {0} and {1} is : {2} ", a, b, a / b);
                    }
                    break;
                default:
                    Console.WriteLine("Input Correct Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
