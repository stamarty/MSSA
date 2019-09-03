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
              Console.WriteLine("Why did you even open this project then?");

            for (int i = 0; i < count; i++)
            {
                fibA = fibB;
                fibB = fibC;
                fibC = fibA + fibB;
                

                Console.Write(fibB + " - ");
            }

            Console.ReadLine();

        }
    }
}
