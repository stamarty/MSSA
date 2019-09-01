﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Supreme";
            car1.VIN = "asdalksu392023kf";

            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Tundra";
            car2.VIN = "19halksdyh98-32";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft.NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            *//*//Array lists are dynamically sized,
            //cool features: sorting, removing etc

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }*//*

            //LIST<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }

            // Dictionary(TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["19halksdyh98-32"].Make);*/

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            //Object Initializer
            //no need for a constructor
            //Car car1 = new Car() { Make = "Tesla", Model = "Model S", VIN = "C3PO" };
            //Car car2 = new Car() { Make = "Torpid", Model = "Turtle", VIN = "4R" };

            //Collection Initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Torpid", Model = "Turtle", VIN = "4R" },
                new Car { Make = "Nissan", Model = "Altima", VIN = "fhfhf" }
            };
            
            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
