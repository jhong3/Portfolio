/*
   Source: https://www.sanfoundry.com/csharp-programs-sort-string-predefined-function/
   Author: Manish Bhojasia
   Summary: This sample program demonstrates how the sort() function can be used
            to sort a an array of strings.
   Date: 19 Apr 2019
   Modifications: ----

*/

using System;
class linSearch
{
    public static void Main()
    {
        // The program initially prints a message requesting user input (Console.ReadLine()).
        // Because the input is a string, the program will assign it to a variable 's' which
        // is declared as a string type. The program then assigns the string to an integer
        // variable 'x' after converting it to an int type using Int32.Parse().
        // Finally, the program once again applies this new int value and assigns it to
        // an int type array variable 'a' as the number elements that will be
        // stored within the new int[] array 'a'.

        Console.WriteLine("Enter Number of Elements you Want to Hold in the Array? ");
        string s = Console.ReadLine();
        int x = Int32.Parse(s);
        int[] a = new int[x];

        // The for loop here will string the user's desired numbers and convert them
        // into int types. It will continuously (i++) take inputs until it meets the
        // maximum number (i < x) of arrays of declared by 'x' from above.

        Console.WriteLine("Enter Array Elements :");
        for (int i = 0; i < x; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = Int32.Parse(s1);
        }

        // Array.Sort() will now sort the elements stored in the array 'a'.
        // With the values in numerical order, the program is instructed to
        // print out the elements of the array 'a' incrementally until the
        // condition i < x returns false using the for loop.

        Array.Sort(a);
        Console.WriteLine("Sorted Array : ");
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("{0}", a[i]);
        }
        Console.Read();
    }
}

/*
        Example Output:
        Enter Number of Elements you Want to Hold in the Array ? 5
        Enter Array Elements : 
        2
        3
        1
        4
        5
        Sorted Array :
        1
        2
        3
        4
        5
*/