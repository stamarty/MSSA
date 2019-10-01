using System;

namespace Mod3Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo(out first, out lastName, out birth);
            PrintStudentInfo(first, lastName, birth);

        }

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

        static void GetTeachInfo()
        {
            Console.WriteLine("Enter teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter teachers's birthday: ");
            string DOB = Console.ReadLine();
        }

        static void PrintTeachInfo(string first, string last, string birth)
        {
            Console.WriteLine("{0} {1} was born on: {2}.", first, last, birth);
        }

        static void GetDegreeInfo()
        {
            Console.WriteLine("What degree are you interested in? ");
            string degree = Console.ReadLine();
            Console.WriteLine("What is the degree ID? ");
            string ID = Console.ReadLine();
            Console.WriteLine("What is the professor's name? ");
            string professor = Console.ReadLine();
        }

        static void PrintDegreeInfo(string degree, string ID, string professor)
        {
            Console.WriteLine("Degree {0} with ID {1} is taught by {2}.", degree, ID, professor);
        }



    }
}
