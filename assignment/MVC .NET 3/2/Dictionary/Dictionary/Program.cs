using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string>student = new Dictionary<string,string>();
            student.Add("ruchi", "patel");
            student.Add("nency", "patel");
            student.Add("shivanee", "patel");
            student.Add("tiki", "patel");
            student.Add("krupa", "patel");

            Console.WriteLine("\n--students Name--\n");
            foreach (KeyValuePair<string, string> name in student)
            {
                Console.WriteLine(" {0} {1}",name.Key,name.Value);
            }
            Console.ReadLine();
        }
        


    }
}
