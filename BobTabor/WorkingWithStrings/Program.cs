using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life!";

            //string myString = "What if I \nneed \na\nnew\nline?";

            //string myString = "Go to your C:\\ drive";
            //string myString = @"Go to your C:\ drive";

            //string myString = string.Format("{0} = {1}", "First", "Second"); //replacements can be re-used or used in any order ({0} = {0} or {1} = {0}).

            //string myString = string.Format("{0:C}", 123.45);//format to current region's currency
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("{0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);//custom number format

            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6, 14);//will display starting at the 7th position and up to the 14th.

            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = String.Format("Length before: {0} -- Length after {1}", 
                myString.Length, 
                myString.Trim().Length);
            */

            /* The following code is inefficient because it requires the process of converting to string each interation
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
