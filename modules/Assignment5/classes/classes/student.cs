using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class student
    {
        private string firstName;
        private string lastName;
        private int year;

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; } 
        }
        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; } 
        }
        public int Year
         {
            get { return year; }
             set { year = value; } 
        }
        
    }
}
