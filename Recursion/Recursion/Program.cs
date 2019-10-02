using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNum(0);
        }
        static void PrintNum(int num)
        {
            Console.WriteLine(num);
            if (num==10)
            {
                return;
            }
            PrintNum(++num);
        }
    }
}
