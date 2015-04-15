using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetSchoolInfo();
            ValidateStudBirthday();
        }
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string sfirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's middle name: ");
            string smiddleName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string slastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday mm/dd/yyyy");
            string sbirthDate = Console.ReadLine();
            PrintStudentDetails(sfirstName, smiddleName, slastName, sbirthDate);
        }
        static void GetSchoolInfo()
        {
            Console.WriteLine("Enter the teachers's first name: ");
            string tfirstName = Console.ReadLine();
            Console.WriteLine("Enter the teachers's middle name: ");
            string tmiddleName = Console.ReadLine();
            Console.WriteLine("Enter the teachers's last name");
            string tlastName = Console.ReadLine();
            Console.WriteLine("Enter the teachers years of experience: ");
            string tYearsExp = Console.ReadLine();
            Console.WriteLine("Enter the course name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the program name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the degree name ");
            string degreeName = Console.ReadLine();
            PrintTeacherDetails(tfirstName, tmiddleName, tlastName, tYearsExp);
            PrintProgramDetails(courseName, programName, degreeName);
        }
        static void ValidateStudBirthday()
        {
            throw new NotImplementedException();
        }
       
        static void PrintStudentDetails(string first, string middle, string last, string birthday)
        {
            Console.WriteLine("{0} {1} {2} was born on: {3}", first, middle, last, birthday);
        }
        static void PrintTeacherDetails(string first, string middle, string last, string yearsExp)
        {
            Console.WriteLine("{0} {1} {2} has been teaching for {3} years.", first, middle, last, yearsExp);
        }
        static void PrintProgramDetails(string course, string program, string degree)
        {
            Console.WriteLine("The course is {0}. The program is: {1}. The degree will be: {2}", course, program, degree);
        }
    }
}
