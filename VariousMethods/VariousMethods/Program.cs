using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
                "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string[] stevenName = new string[6] { "s", "t", "e", "v", "e", "n" };

            ReverseArray(newArray);
            ReverseArray(stevenName);

            Console.WriteLine("------------");

            string lName = "Martinez";
            char[] reversedLastName = lName.ToCharArray();
            Array.Reverse(reversedLastName);
            foreach (char c in reversedLastName)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("------------");

            char[] backwardsNumber = "fortytwo".ToCharArray();
            Array.Reverse(backwardsNumber);
            foreach (char c in backwardsNumber)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            Console.WriteLine("------------");

            Array.Reverse(backwardsNumber, 3, 5);
            foreach (char c in backwardsNumber)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            Console.WriteLine("------------");

            int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            Array.Reverse(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------");

        }

        public static string[] ReverseArray(string[] arr)
        {
            for (int i = 0, j=arr.Length-1; i < j; i++, j--)
            {
                string temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;                
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
            return arr;
        }
    }
}
