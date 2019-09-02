using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ //Language Integrated Query Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2019 },
                new Car() { VIN = "B2", Make = "Tesla", Model = "Model S", StickerPrice = 100000, Year = 2019 },
                new Car() { VIN = "C3", Make = "Toyota", Model = "Tundra", StickerPrice = 60000, Year = 2012 },
                new Car() { VIN = "D4", Make = "Chevy", Model = "Bolt", StickerPrice = 50000, Year = 2018 },
                new Car() { VIN = "E5", Make = "Ford", Model = "Mustang", StickerPrice = 45000, Year = 2017 },
                new Car() { VIN = "F6", Make = "BMW", Model = "750i", StickerPrice = 75000, Year = 2016 },
            };

            //LINQ query
            /*var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2019
                       select car;*/

            /*var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;*/


            //LINQ method
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2019);
            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            /*var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);*/
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            /*myCars.ForEach(p => p.StickerPrice -= 3000);
            myCars.ForEach(p => Console.WriteLine("{1:C} - {0}", p.VIN, p.StickerPrice));*/

            //Console.WriteLine(myCars.Exists(p => p.Model == "Model S"));

            //Console.Write("{0:C}", myCars.Sum(p => p.StickerPrice));


            /*foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", car.Year, car.Model, car.VIN, car.StickerPrice);
            }*/

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2019);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2019
                       select new { car.Make, car.Model };

            Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
