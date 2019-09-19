using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Mod2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Counter is at {counter}");
            }

            int outer;
            int inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer/inner); inner++)
                {
                    if ((outer % inner) == 0) break; 
                }

                if (inner > (outer / inner))
                {
                    Console.WriteLine($"{outer} is prime.");
                }
            }
        }
    }
}
