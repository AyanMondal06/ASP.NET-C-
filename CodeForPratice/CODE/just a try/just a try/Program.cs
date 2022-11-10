using System;

class lol
{

    // Main Method
    public static void Main()
    {

        // declaring and initializing the array
        int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

        // Sort array in ascending order.
        Array.Sort(arr);
        Console.WriteLine("Ascending: ");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }

        // reverse array
        Array.Reverse(arr);
        Console.WriteLine("\n\nDescending: ");
        // print all element of array
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }
}