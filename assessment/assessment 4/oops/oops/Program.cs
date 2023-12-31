using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tLecture Management");
            Console.WriteLine("\t\t\t\t------------------");

            Lecture lecture = new Lecture();
            lecture.LoadOperations();
            Console.ReadLine();

        }
        public class Lecture
        {
            string LecturerName;
            string SubjectName;
            string CourseName;
            int LecturersNumber;

            //used to store lecture detail
            List<Lecture> lectures = new List<Lecture>();

            //constructor
            public Lecture()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Title = "\nLecture Management System";                
            }

            public void LoadOperations()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nChoose an option from the following list : ");
                Console.WriteLine("\t a - Add Lecture Detail");
                Console.WriteLine("\t b - View Lecture Detail");
                Console.WriteLine("Your option?");

                //use a switch statement to do all operations.
                switch(Console.ReadLine())
                {
                    case "a":
                        AddLectureInfo();
                        break;
                    case "b":
                        LectureDetails(); 
                        break;
                    default:
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("\nplease choose correct option from the list");
                        break;
                }
            }

            public void AddLectureInfo()
            {
                Lecture lec = new Lecture();

                Console.ForegroundColor= ConsoleColor.DarkMagenta;
                Console.Write("\nPlease add name of the lecturer : ");
                lec.LecturerName = Console.ReadLine();

                Console.Write("Please add name of the subject : ");
                lec.SubjectName = Console.ReadLine();

                Console.Write("Please add name of course : ");
                lec.CourseName = Console.ReadLine();

                Console.Write("Please add number of lecturers (must use integer number) : ");
                lec.LecturersNumber = int.Parse(Console.ReadLine());

                //add lecture detail in list
                lectures.Add(lec);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLecture detail add succesfully");

                LoadOperations();
            }
            public void LectureDetails()
            {
                if(!lectures.Any())
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nsorry,please add lecture detail first!");
                    LoadOperations() ;
                }
                else 
                { 
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    for(int i = 0; i < lectures.Count; i++)
                    {
                        Console.WriteLine("\nName of  lecturer   : {0}", lectures[i].LecturerName);
                        Console.WriteLine("Name of  subject    : {0}", lectures[i].SubjectName);
                        Console.WriteLine("Name of  course     : {0}", lectures[i].CourseName);
                        Console.WriteLine("Number of  lecturer : {0}", lectures[i].LecturersNumber);
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    LoadOperations();
                }
            }

        }
    }
}
