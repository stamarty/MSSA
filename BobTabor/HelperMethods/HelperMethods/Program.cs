using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What is your first name? ");
            string firstname = Console.ReadLine();

            Console.Write("What is your Last Name ");
            string lastname = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            Console.Write("In what State were you born? ");
            string state = Console.ReadLine();


            DisplayResult(ReverseString(firstname),
            ReverseString(lastname),
            ReverseString(city),
            ReverseString(state));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity,
            string reversedState)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2} {3}", 
                reversedFirstName, 
                reversedLastName, 
                reversedCity,
                reversedState)); 

        }



    }
}
