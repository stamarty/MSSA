using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            /*myCar.Color = "Black";
            myCar.Year = 2012;
            myCar.Make = "Toyota";
            myCar.Model = "Tundra";

            //Car myThirdCar = new Car("Grey", 2017, "Chevrolet", "Bolt");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Color, 
                myOtherCar.Year, 
                myOtherCar.Make, 
                myOtherCar.Model);
            
            myOtherCar.Model = "Tacoma";

            Console.WriteLine("{0} {1} {2} {3}",
               myCar.Color,
               myCar.Year,
               myCar.Make,
               myCar.Model);

            myOtherCar = null;
            
            //Throws exception because myOtherCar is no longer living at the address (bucket handle was broken, or whatever analogy fits)
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Color,
                myOtherCar.Year,
                myOtherCar.Make,
                myOtherCar.Model);
         
            myCar = null;*/

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

       /* public Car()
        {
            //you can load from a configuration file,
            //a database or whatever
            Make = "Nissan";
        }

        public Car(string color, int year, string make, string model)
        {
            Color = color;
            Year = year;
            Make = make;
            Model = model;
        }*/

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }


    }
}
