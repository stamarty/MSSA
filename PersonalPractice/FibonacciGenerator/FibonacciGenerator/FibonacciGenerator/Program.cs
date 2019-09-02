using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibA = 0;
            int fibB = 1;
            int fibC = 0;

            Console.Write("How many numbers in the Fibonacci Sequence would you like me to display?");
            string desiredNumber = Console.ReadLine();

            Console.WriteLine("Ok, I'll display {0} numbers in the sequence", desiredNumber);

            Int32.TryParse(desiredNumber, out int count);

            if (count == 0)
                Console.WriteLine("Your Fibonacci number is {0}", fibA);

            for (int i = 0; i < count; i++)
            {
                fibC = fibA + fibB;
                fibA = fibB;
                fibB = fibC;

                Console.Write(fibC + " - ");
            }

            Console.ReadLine();

        }
    }
}
