using System;

namespace CountUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What message would you like to say? ");
            string userMessage = Console.ReadLine();
            Console.Write("How many times do you want to say it? ");
            string repeat = Console.ReadLine();

            int repeatNumber;

            int.TryParse(repeat, out repeatNumber);

            Console.WriteLine("You wanted to say " 
                + userMessage + " " +
                + repeatNumber 
                + " times!? Here you go!");

            for (int i = 0; i < repeatNumber; i++)
            {
                Console.WriteLine(userMessage);
            }

            Console.Write("I hope that was fun for you.");

            Console.ReadLine();

        }
    }
}
