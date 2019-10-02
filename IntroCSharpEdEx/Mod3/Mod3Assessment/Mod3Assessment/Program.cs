using System;

namespace Mod3Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo(out string firstName, out string lastName, out string birth);
            PrintStudentInfo(firstName, lastName, birth);

            GetTeachInfo(out string teachFirst, out string teachLast, out string teachDOB);
            PrintTeachInfo(teachFirst, teachLast, teachDOB);

            GetDegreeInfo(out string degree, out string ID, out string professor);
            PrintDegreeInfo(degree, ID, professor);

        }

        #region Student Info

        static void GetStudentInfo(out string firstName, out string lastName, out string birth)
        {
            Console.WriteLine("Enter Student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Student's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Student's birthday: ");
            birth = Console.ReadLine();
        }

        static void PrintStudentInfo(string first, string last, string birth)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birth);
        }

        #endregion

        #region  Teacher Info
        static void GetTeachInfo(out string firstName, out string lastName, out string DOB)
        {
            Console.WriteLine("Enter teacher's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter teacher's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter teachers's birthday: ");
            DOB = Console.ReadLine();
        }

        static void PrintTeachInfo(string first, string last, string birth)
        {
            Console.WriteLine("{0} {1} was born on: {2}.", first, last, birth);
        }
        #endregion

        #region Degree Info
        static void GetDegreeInfo(out string degree, out string ID, out string professor)
        {
            Console.WriteLine("What degree are you interested in? ");
            degree = Console.ReadLine();
            Console.WriteLine("What is the degree ID? ");
            ID = Console.ReadLine();
            Console.WriteLine("What is the professor's name? ");
            professor = Console.ReadLine();
        }

        static void PrintDegreeInfo(string degree, string ID, string professor)
        {
            Console.WriteLine("Degree {0} with ID {1} is taught by {2}.", degree, ID, professor);
        }
        #endregion



    }
}
