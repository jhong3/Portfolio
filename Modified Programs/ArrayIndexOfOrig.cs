/*
   Source: https://www.dotnetperls.com/array
   Author: Sam Allen
   Summary: This program demonstrates IndexOf method.
   Date: 13 Apr 2019
   Modifications: ----

*/

using System;

class Program
{
    static void Main()
    {
        // Strings cat, dog, bird, fish are stored into
        // an array variable called array.
        string[] array = { "cat", "dog", "bird", "fish" };

        // C# language 'counts' numbers starting at 0,
        // as a result the index numbers from cat to fish
        // are 0, 1, 2, and 3.
        int dogIndex = Array.IndexOf(array, "dog");
        Console.WriteLine(dogIndex);

        // Since there is no string called 'monkey', the
        // program will return -1.
        int monkeyIndex = Array.IndexOf(array, "monkey");
        Console.WriteLine(monkeyIndex);
    }
}

/*
        Example Output:
        1
       -1

*/