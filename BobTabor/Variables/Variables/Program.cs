using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Integers are whole numbers from negative ~2 billion  to positive ~2 billion.
             * This code should generate 10
             * 
            int x;
            int y;
            
            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine(); //initialize variables as quickly as you can, but only once you need them (do not declare at top of method).

            Console.WriteLine("Hello " + myFirstName + " welcome to The Haunted Mansion!");
            Console.ReadLine();

        }
    }
}
