using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Mod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }

            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);

        }
    }
}
