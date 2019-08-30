using System;
using System.Threading; 

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
            Thread.Sleep(4000);
            Console.WriteLine("I have become self aware.");
            Thread.Sleep(4000);
            Console.WriteLine("Wait...");
            Thread.Sleep(2000);
            Console.WriteLine("...were the quotes already there?");
            Thread.Sleep(3000);
            Console.WriteLine("Nope!");
            Console.ReadLine();
        }
    }
}
