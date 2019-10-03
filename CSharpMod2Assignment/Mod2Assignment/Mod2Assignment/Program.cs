using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading methods.  A method can have the same name as another method
            //as long as the method sigs are different. I created 3 methods below, all with the same name, 
            //but all with different signatures. I'll call them here in the main method. 

            countTo(); //no parameters
            countTo(14); //one parameter will count the integer back from num.
            countTo(42, "You wrote the number ");

           
        }

        //method has no parameters but can be called to only do the thing in the method.
        static void countTo()
        {
            Console.WriteLine("We're not even counting here!");
        }

        //method has one parameter which will be passed in if desired. 

        static void countTo(int num) // accepts integer as an input
        {
            while (num > 0)
            {
                Console.WriteLine(num.ToString()); //prints the current number decrementing through the if statement, converts num to string. 
                num--;
            }

                Console.WriteLine("BLASTOFF!!");//blasts the rocket into outerspace. 
            
        }

        //finally we will pass in 2 parameters into this same named method.
        static void countTo(int num, string words)
        {
            Console.WriteLine(words + num.ToString());
        }
    }
}
