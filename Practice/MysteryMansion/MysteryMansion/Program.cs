using System;

namespace TheMysterMansion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mystery Mansion");
            Console.WriteLine("");
            Console.Write("What should I call you, stranger? ");
            string name = Console.ReadLine();

            name = name.ToUpper();

            Console.WriteLine(name +
                " that's a good name. A good strong name. You'll need strength to get through this mansion, "
                + name + ", strength, intelligence and not a little bit of luck.");

            Console.ReadLine();
        }
    }
}