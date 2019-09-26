using System;
using System.IO;

namespace CSharpMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO System Namespace

            //TODO Function BEEP
            //plays a sound through the speakers.

            //Console.Beep();

            //Console.Beep(500, 2000);
            //Console.Beep(750, 2000);
            //Console.Beep(1000, 2000);
            //Console.Beep();

            //Console.WriteLine("How many beeps do you want to hear?");
            //string beepNum = Console.ReadLine();
            //int x;
            //Int32.TryParse(beepNum, out x);

            //for (int i = 1; i <= x; i++)
            //{
            //    Console.WriteLine("Beep number {0}.", i);
            //    Console.Beep();
            //}



            //-------------------------------------
            //TODO Method MATH.POW
            //Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.
            //Hypotenuse - WRONG

            //Console.WriteLine("Let's find a hypontenuse! (press 'enter' to continue)");
            //Console.ReadLine();
            //Console.WriteLine("What is the length of the short side?");
            //string sLength = Console.ReadLine();
            //Console.WriteLine("What is the length of the long side?");
            //string lLength = Console.ReadLine();
            //double a, b;
            //double.TryParse(sLength, out a);
            //double.TryParse(lLength, out b);
            //double aLength = Math.Pow(a, 2);
            //double bLength = Math.Pow(b, 2);
            //double cLength = (aLength + bLength);
            //Console.WriteLine("Your hypotenuse is {0}.", cLength);

            //-------------------------------------
            //TODO - Math.SQRT
            //Hypotenuse - Correct

            //Console.WriteLine("Let's find a hypontenuse! (press 'enter' to continue)");
            //Console.ReadLine();
            //Console.WriteLine("What is the length of the short side?");
            //string sLength = Console.ReadLine();
            //Console.WriteLine("What is the length of the long side?");
            //string lLength = Console.ReadLine();
            //double a, b;
            //double.TryParse(sLength, out a);
            //double.TryParse(lLength, out b);
            //double aLength = Math.Pow(a, 2);
            //double bLength = Math.Pow(b, 2);
            //double cLength = Math.Sqrt(aLength + bLength);
            //Console.WriteLine("Your hypotenuse is {0}.", cLength);

            //-------------------------------------

            //TODO Function Math.Round
            //Rounds a number to an integer by using normal rounding conventions.

            //double q = Math.Round(31.45);
            //double r = Math.Round(31.55);
            //Console.WriteLine("31.45 rounded is {0}", q);
            //Console.WriteLine("31.55 rounded is {0}", r);

            //double s = Math.Round(31.44555, 2);
            //double t = Math.Round(31.44455, 2);
            //Console.WriteLine("31.44555 rounded 2 places is {0}", s);
            //Console.WriteLine("31.44455 rounded 2 places is {0}", t);

            //-------------------------------------
            //TODO Function 5
            //Array type mismatch exception

            //string[] siblings = { "john", "jamie", "robert", "simon" };
            //Object[] objs = (Object[]) siblings;
            //try
            //{
            //    foreach (object name in objs)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //catch (ArrayTypeMismatchException)
            //{
            //    Console.WriteLine("Exception Thrown");
            //}

            //try
            //{
            //    Object obj = (Object)42;
            //    objs[3] = obj;
            //}
            //catch (ArrayTypeMismatchException)
            //{
            //    Console.WriteLine("Array Type Mismatch Exception: Incorrect Type Added");
            //}

            //-------------------------------------
            //-------------------------------------

            //TODO System.IO
            //The System.IO namespace contains types that allow reading and writing to files and data streams, 
            //and types that provide basic file and directory support.

            //TODO File Class
            //create method

            //-------------------------------------

            //Console.WriteLine("Let's create a file.");
            //using (File.Create("E:\\Program Files\\Repos\\MSSA\\CSharpMidterm\\iheartcsharp.txt")) ;
            //Console.WriteLine("iheartcsharp created.");
            //Console.ReadLine();

            ////TODO WriteAllText Method
            //string text = "Hello World";
            //File.WriteAllText("E:\\Program Files\\Repos\\MSSA\\CSharpMidterm\\iheartcsharp2.txt", text);
            //Console.WriteLine("iheartcsharp2 created.");
            //Console.ReadLine();

            ////TODO Copy Method

            //File.Copy("E:\\Program Files\\Repos\\MSSA\\CSharpMidterm\\iheartcsharp2.txt", "E:\\Program Files\\Repos\\MSSA\\CSharpMidterm\\iheartcsharp.txt", true);
            //Console.WriteLine("iheartcsharp2 copied to iheartcsharp.");
            //Console.ReadLine();

            ////TODO ReadAllText Method

            //string contents = File.ReadAllText("E:\\Program Files\\Repos\\MSSA\\CSharpMidterm\\iheartcsharp.txt");
            //Console.WriteLine("iheartcsharp contained the following text: {0} ", contents);
            //Console.ReadLine();

            ////TODO Delete Method
            //File.Delete("E:\\Program Files\\Repos\\MSSA\\CSharpMidterm\\iheartcsharp.txt");
            //Console.WriteLine("iheartcsharp deleted");
            //Console.ReadLine();

            //File.Delete("E:\\Program Files\\Repos\\MSSA\\CSharpMidterm\\iheartcsharp2.txt");
            //Console.WriteLine("iheartcsharp2 deleted");
            //Console.ReadLine();

            //-------------------------------------
            //-------------------------------------



            //TODO Namespace 3
            //TODO Function 1
            //TODO Function 2
            //TODO Function 3
            //TODO Function 4
            //TODO Function 5

            Console.WriteLine("Hello, World!");


        }
        
    }
}
