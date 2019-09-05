using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {



            try
            {
                string content = File.ReadAllText(@"C:\Users\Dominator\Desktop\KeywordSearching.txt");
                Console.WriteLine(content);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is correct");
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the directory exists");
            }

            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                //code to finalize
                //set objects to null
                //Closeing database connections
                Console.WriteLine("Closing the application now!");
            }
            Console.ReadLine();
        }
    }
}
