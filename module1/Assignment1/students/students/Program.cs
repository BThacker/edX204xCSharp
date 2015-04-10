using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mark";
            string lastName = "NoName";
            string birthDate = "10/10/1901";
            string addressLine1 = "999 Microsoft Way";
            string addressLine2 = "Suite 150";
            string city = "Atlanta";
            string state = "Georgia";
            int postalCode = 30303;
            string country = "United States";

            string professorName = "edX";


            string degreeName = "Bachelor of Science IT";
            int degreeCreditReq = 130;

            string programName = "DEV204x Programming with C#";

            string degree1 = "Bachelor";
            string degree2 = "Master";
            string degree3 = "Ph.D.";

            Console.WriteLine("---Student Information---");
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Birth Date: " + birthDate);
            Console.WriteLine("Address: " + addressLine1 + " " + addressLine2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zipcode: " + postalCode.ToString());
            Console.WriteLine("Country: " + country);
            Console.WriteLine();
            Console.WriteLine("Professor Name: " + professorName);
            Console.WriteLine();
            Console.WriteLine("Degree Pursued: " + degreeName);
            Console.WriteLine("Credit Required: " + degreeCreditReq.ToString());
            Console.WriteLine();
            Console.WriteLine("Program Name: " + programName);
            Console.WriteLine("Degree's Offered: " + degree1 + ", " + degree2 + ", " + degree3);



            Console.ReadLine();

        }
    }
}
