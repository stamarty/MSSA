using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //student data
            string studentFirst;
            string studentLast;
            DateTime studentDOB;
            string studentAddressLine1;
            string studentAddressLine2;
            string studentCity;
            string studentState;
            int studentZip;
            string studentCountry;
            //teacher data
            string teacherFirst;
            string teacherLast;
            DateTime teacherDOB;
            string teacherAddressLine1;
            string teacherAddressLine2;
            string teacherCity;
            string teacherState;
            int teacherZip;
            string teacherCountry;
            //UProgram Information
            string programName;
            string departmentHead;
            string degrees;
            //Degree Information
            string degreeName;
            int creditsRequired;
            //Course Information
            string courseName;
            int credits;
            int durationWeeks;
            string teacher;

            //let's make a student
            studentFirst = "John";
            studentLast = "Johnson";
            studentDOB = new DateTime(1980, 11, 28);
            studentAddressLine1 = "1234 Anywhere St.";
            studentAddressLine2 = "Apartment 2";
            studentCity = "Somewhere";
            studentState = "Washington";
            studentZip = 98654;
            studentCountry = "USA";

            Console.WriteLine("{0} {1}, born {2}, lives at {3} {4} {5} {6} {7} {8}", studentFirst, studentLast, 
                studentDOB, studentAddressLine1, studentAddressLine2, studentCity, studentState, studentZip, 
                studentCountry);
            
            //let's build a teacher
            teacherFirst = "Gina";
            teacherLast = "Jones";
            teacherDOB = new DateTime(1975, 10, 2);
            teacherAddressLine1 = "1234 Anywhere St."; 
            teacherAddressLine2 = "Apartment 3";
            teacherCity = "Somewhere";
            teacherState = "Washington";
            teacherZip = 98564;
            teacherCountry = "USA";

            Console.WriteLine();
            Console.WriteLine("{0} {1}, born {2}, lives at {3} {4} {5} {6} {7} {8}", teacherFirst, teacherLast,
                teacherDOB, teacherAddressLine1, teacherAddressLine2, teacherCity, teacherState, teacherZip,
                teacherCountry);

            //University Program Information
            programName = "Hard Knocks";
            departmentHead = "Tony Stark";
            degrees = "All of them";

            Console.WriteLine();
            Console.WriteLine("{0} -- {1} -- {2}", programName, departmentHead, degrees);

            //degree information
            degreeName = "Master's Degree";
            creditsRequired = 200;

            Console.WriteLine();
            Console.WriteLine("{0} -- {1}", degreeName, creditsRequired);

            //course information
            courseName = "Beat 'em up";
            credits = 12;
            durationWeeks = 56;
            teacher = "Steve Rogers";

            Console.WriteLine();
            Console.WriteLine("{0} -- {1} -- {2} -- {3}", courseName, credits, durationWeeks, teacher);

            //finally we'll ask for input for the student information
            Console.WriteLine("Let's build a student, shall we?");
            Console.WriteLine("input student first name: ");
            studentFirst = Console.ReadLine();
            Console.WriteLine("input student last name: ");
            studentLast = Console.ReadLine();
            Console.WriteLine("input student Date of birth (year, mm, dd) ");
            string sdob = Console.ReadLine(); 
            studentDOB = Convert.ToDateTime(sdob);
            Console.WriteLine("input student address line 1: ");
            studentAddressLine1 = Console.ReadLine();
            Console.WriteLine("input student address line 2: ");
            studentAddressLine2 = Console.ReadLine();
            Console.WriteLine("input student city: ");
            studentCity = Console.ReadLine();
            Console.WriteLine("input student state: ");
            studentState = Console.ReadLine();
            Console.WriteLine("input student zip: ");
            string zip = Console.ReadLine();
            studentZip = Convert.ToInt32(zip);
            Console.WriteLine("input student country: ");
            studentCountry = Console.ReadLine();

            Console.WriteLine("{0} {1}, born {2}, lives at {3} {4} {5} {6} {7} {8}", studentFirst, studentLast,
                studentDOB, studentAddressLine1, studentAddressLine2, studentCity, studentState, studentZip,
                studentCountry);

        }
    }
}
