//Write a Program that counts the number of vowels and consonants used in the string entered

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counts_the_number_of_vowels_and_consonants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string a = Console.ReadLine();
            int c = 0;
            int v = 0;

            int stringlength = a.Length;
            
            for (int i = 0; i < stringlength; i++)
            {
                if (a[i]=='a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                {
                    v++;
                }
                
                else
                {
                    c++;
                }
            }
            Console.WriteLine("\nvowels = {0}", v);
            Console.WriteLine("consonants = {0}", c);
            Console.ReadLine();
        }
    }
}
