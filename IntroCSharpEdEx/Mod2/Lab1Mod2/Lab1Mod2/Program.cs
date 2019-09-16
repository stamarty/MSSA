using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter and integer value and press Enter.");

            int input = Int32.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("The entered number, {0}, is an even number! ", input);
            }
            else
            {
                Console.WriteLine("The entered number, {0}, is an odd number! ", input);
            }
        }
    }
}
