using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class course
    {
        private string courseName = "Programming with C#";
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; } 
        }

        public student[] StudentArray = new student[3];
        public teacher[] TeacherArray = new teacher[3];
    }
}
