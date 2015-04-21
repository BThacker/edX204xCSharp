using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            student brandon = new student();
            student mark = new student();
            student rick = new student();

            brandon.FirstName = "Brandon";
            brandon.LastName = "LastName";
            brandon.Year = 2;

            mark.FirstName = "Mark";
            mark.LastName = "LastName";
            mark.Year = 3;

            rick.FirstName = "Rick";
            rick.LastName = "LastName";
            rick.Year = 1;

            course ProgrammingWithCSharp = new course(); 

            ProgrammingWithCSharp.StudentArray[0] = brandon;
            ProgrammingWithCSharp.StudentArray[1] = mark;
            ProgrammingWithCSharp.StudentArray[2] = rick;

            teacher rumple = new teacher();

            ProgrammingWithCSharp.TeacherArray[0] = rumple;

            degree bachelor = new degree();
            bachelor.Bachelor = ProgrammingWithCSharp;

            uprogram InformationTechnology = new uprogram();
            InformationTechnology.Bachelor = bachelor;

            Console.WriteLine("The {0} program contains the {1} degree.", InformationTechnology.ProgramName, bachelor.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}.", bachelor.DegreeName, ProgrammingWithCSharp.CourseName);
            Console.WriteLine("The {0} course contains {1} students.", ProgrammingWithCSharp.CourseName, ProgrammingWithCSharp.StudentArray.Length);
    
        }
    }
}
