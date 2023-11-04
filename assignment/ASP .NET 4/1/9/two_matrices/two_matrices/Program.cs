//Write a program in C# Sharp to accept two matrices and check whether they are equal.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int i;
            int j;
            int flag = 1;

            Console.Write("Input the number of rows in the 1st matrix : ");
            int r1 = int.Parse(Console.ReadLine());
            Console.Write("Input the number of columns in  the 1st matrix : ");
            int c1 = int.Parse(Console.ReadLine());

            Console.Write("Input the number of rows in the 2nd matrix : ");
            int r2 = int.Parse(Console.ReadLine());
            Console.Write("Input the number of columns in  the 2nd matrix : ");
            int c2 = int.Parse(Console.ReadLine());

            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("The first matrix is :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("{0}  ", arr1[i, j]);
                }               
                Console.Write("\n");
            }
            Console.Write("The second matrix is :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("{0}  ", arr2[i, j]);
                }                
                Console.Write("\n");
            }

            if (r1 != r2 && c1 != c2)
            {
                Console.Write("The Matrices Cannot be compared :\n");
            }
            else
            {
                Console.Write("The Matrices can be compared : \n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        if (arr1[i, j] != arr2[i, j])
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if (flag == 1)
                {
                    Console.Write("Two matrices are equal.\n\n");
                }
                    
                else
                {
                    Console.Write("But,two matrices are not equal\n\n");
                }
                Console.ReadLine();
                      
            }
        }
    }
}
