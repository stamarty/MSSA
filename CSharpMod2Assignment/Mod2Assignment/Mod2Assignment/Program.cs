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

            //creating a tracker to help maintain accountability of my Son's Boy Scout Troop. 
            //We're practicing using the "OUT" keyword. The method allows the the variables assigned to be referenced 
            //outside the method. The variables have to be declared during the time of method call. They do not have to be 
            //declared inline (but it looks nicer). 
            GetScoutInfo(out string firstName, out string lastName, out string birth);
            PrintScoutInfo(firstName, lastName, birth); //the parameters of this method are from the GetScoutInfo method. 
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
                Console.WriteLine(num.ToString()); //prints the current number decrementing through the while statement, converts num to string. 
                num--;
            }

                Console.WriteLine("BLASTOFF!!");//blasts the rocket into outerspace. 
            
        }

        //finally we will pass in 2 parameters into this same named method.
        static void countTo(int num, string words)
        {
            Console.WriteLine(words + num.ToString());
        }

        //this method asks for the Boy Scout's name and assigns an appropriate variable. The variables are then allowed
        //OUT of the method to act as variables when the method is called.
        static void GetScoutInfo(out string firstName, out string lastName, out string birth)
        {
            Console.WriteLine("Enter Scout's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Scout's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Scout's birthday: ");
            birth = Console.ReadLine();
        }
        //this method just concatenates and prints the information from the above method.
        static void PrintScoutInfo(string first, string last, string birth)
        {
            Console.WriteLine("Scout {0} {1} was born on: {2}", first, last, birth);
        }
    }
}
