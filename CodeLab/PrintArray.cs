using System;

// <summary>
//Write the definition of a method PrintArray, which has one parameter, an array of ints. 
    //The method does not return a value. 
    //The method prints out each element of the array, on a line by itself, 
    //in the order the elements appear in the array, and does not print anything else.
// </summary>


public class PrintArray
{
    int[] newArray = new int[5] { 1, 2, 3, 4, 5 };

    public static void PrintArray(int[] k)
        {

            for (int i = 0; i < k.Length; i++)
            {

                Console.WriteLine(k[i]);

            }

        }
}
