using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            /*         
            //Typical Display of date and time. Locale based.
            Console.WriteLine(myValue.ToString());
            //Date
            Console.WriteLine(myValue.ToShortDateString());
            //Time
            Console.WriteLine(myValue.ToShortTimeString());
            //Long form version of the date (day, Month, Date, year)
            Console.WriteLine(myValue.ToLongDateString());
            //Long form of time H:MM:SS
            Console.WriteLine(myValue.ToLongTimeString());
            */

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myValue.Month);
            //Console.WriteLine(myValue.AddHours(5).Hour);

            //DateTime myBirthday = new DateTime(1980, 11, 28);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("11/28/1980");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
