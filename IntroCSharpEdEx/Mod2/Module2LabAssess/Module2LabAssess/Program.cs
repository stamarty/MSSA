using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2LabAssess
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column+=2)
                {
                    string white = "X";
                    string black = "O";

                    //checks if row is even or odd
                    if (row % 2 == 0)
                    {
                        Console.Write(white);
                        Console.Write(black);
                    }
                    else
                    {
                        Console.Write(black);
                        Console.Write(white);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
