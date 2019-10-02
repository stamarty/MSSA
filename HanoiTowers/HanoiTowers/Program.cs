using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(1, 'A', 'C', 'B');
        }
        public static void Hanoi(int n, char from, char to, char intermediary)
        {
            if (n > 0)
            {
                Hanoi(n - 1, from, intermediary, to);
                Console.WriteLine(from + "->" + to);
                Hanoi(n - 1, intermediary, to, from);
            }
        }
    }
}
