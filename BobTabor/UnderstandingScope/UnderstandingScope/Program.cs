using System;

namespace UnderstandingScope
{
    class Program
    {
        static void Main(string[] args)
        {

            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);
            }

            Console.WriteLine("Outside of the for: " + j); //works because j was declared outside the for block
            Console.ReadLine();
        }
    }
}
