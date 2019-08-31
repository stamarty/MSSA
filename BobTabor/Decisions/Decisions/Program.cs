using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Steven's Mystery Mansion");
            Console.Write("Choose a door: Type 1, 2, or 3 and push enter if you dare: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
            {
                message = "You win nothing because you chose wrong!";
            }
            else if (userValue == "2")
            {
                message = "You won a hug and high-five from mom and dad.";
            }
            else if (userValue == "3")
            {
                message = "You smell like a shoe!!";              
            }
            else
            {
                message = "Easy there! Pick one of the available options! Don't go rogue on me now.";       
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
