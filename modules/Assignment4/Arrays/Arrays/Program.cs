using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Student brandon = new Student();
            brandon.firstName = "Brandon";
            brandon.lastName = "LastName";
            brandon.age = 28;

            Student[] studArray = new Student[5];
            studArray[0] = new Student();
            studArray[1] = new Student();
            studArray[2] = new Student();
            studArray[3] = new Student();
            studArray[4] = new Student();

            studArray[0].firstName = "TestingArrayName";
            Console.WriteLine(brandon.firstName);
            Console.WriteLine(brandon.lastName);
            Console.WriteLine(brandon.age);
            Console.WriteLine(studArray[0].firstName);

        }
    }
    public struct Student
    {
        public string firstName;
        public string lastName;
        public int age;
    }
    public struct Teacher
    {
        public string firstName;
        public string lastName;
        public int yearsTeaching;
    }
    public struct ProgramDetails
    {
        public string name;
    }
    public struct Course
    {
        public string name;
    }
    public struct Degree
    {
        public string name;
        public int yearsLeft;
    }
}
