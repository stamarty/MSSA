using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //required to use the 'Hashtable Collection'

namespace MartinezMod3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Hashtable collection.
            Hashtable ingredients = new Hashtable(); //creates a new hashtable this is similar to a dictionary in that it associates keys, with values. 
            // Add some key/value pairs to the collection.
            ingredients.Add("Café au Lait", "Coffee, Milk");
            ingredients.Add("Café Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");
            ingredients.Add("Coffee", "Coffee, Coffee, More Coffee"); //ingredients.Add enters data into the hashtable. In this situation only one key for one value.  
            ingredients.Add("Juice", "No coffee, wish there was coffee, seriously (-;"); //you can use a list as one value for the hashtable. 

            //loop through each key and print associated values.
            foreach (string key in ingredients.Keys) //call the keys from the hashtable we're iterating through the hashtable here. notice having to cast the data back to a string. 
                //hashtables are implicitly stored as objects.
            {
                Console.WriteLine("The ingredients of a {0} are {1}.",key, ingredients[key]); //prints the key, then the values associated with each key. 
            }

            Console.WriteLine("----------------");

            foreach (string value in ingredients.Keys) //reversing here and calling values per key first. 
            {
                Console.WriteLine("The ingredients {0} are associated with the drink {1}", ingredients[value], value);
            }

            Console.WriteLine("----------------");

            // Check whether a key exists.
            if (ingredients.ContainsKey("Café Mocha")) //checking to see if the hashtable contains a specific value. This should be wrapped in a try/catch block.
            {
                // Retrieve the value associated with a key.
                Console.WriteLine("The ingredients of a Café Mocha are: {0}", ingredients["Café Mocha"]); //found "Cafe Mocha" key so print ingredients associated. 
            }
        }
    }
}
