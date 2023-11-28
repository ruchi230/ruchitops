using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_in_descending_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string : ");
            string a = Console.ReadLine();
            char temp;
            char[] arr;

            int len = a.Length;
            arr = a.ToCharArray(0,len);

            for (int i = 0; i < len; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (arr[j] > arr[i])
                    {                        
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;                                               
                    }
                }
            }
            Console.WriteLine("String in descending order : ");
            foreach (char c in arr)
            {
                temp = c;
                Console.Write("{0} ",temp);
            }

            Console.ReadLine();
        }
    }
}
