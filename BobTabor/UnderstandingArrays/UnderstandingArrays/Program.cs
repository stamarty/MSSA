using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            /*
            int[] numbers = new int[] { 1, 2, 4, 8, 15, 16, 23, 42, 56 };
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            /*
            string[] names = new string[] { "Steven", "Amanda", "Cierra", "Steven James" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("There are " + names.Length + " names on your list!");
            Console.ReadLine();
            */

            string zig = "You can get what you want out of life " +
                "if you help enough people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }

    }
}
