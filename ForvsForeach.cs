/*
   Source: https://www.geeksforgeeks.org/c-sharp-using-foreach-loop-in-arrays/
   Author: SoM15242
   Summary: This program shows two ways to print an identical text using
            for and foreach to loop in an array.
   Date: 5 May 2019
   Modifications: ----

 */

using System;

class GFG
{

    public static void Main()
    {

        // A char[] type array is initialized with the variable
        // 'arr' to hold the assigned elements.
        char[] arr = {'G', 'e', 'e', 'k', 's',
                        'f', 'o', 'r', 'G', 'e',
                                 'e', 'k', 's'};


        Console.Write("Array printing using for loop = ");

        // The simple for-loop will iterate through all of the
        // elements in the array until the statement is false.
        // The 'i' variable indicates the position of the
        // element stored in the 'arr' array. The for-loop
        // block then prints each corresponding element until
        // 'i' is less than the char array's length (the total
        // number of elements in the array).

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();

        Console.Write("Array printing using foreach loop = ");

        // The foreach is simpler loop as it will loop through
        // each char data type of the element 'ch' stored in
        // the 'arr' array and print each othe 'ch' variable.
        // Unlike the for-loop, foreach will iterate through
        // each element until there are no more elements instead
        // of breaking when the for-loop statement is false.
        foreach (char ch in arr)
        {
            Console.Write(ch);
        }
    }
}

/*      
        Example output:
        Array printing using for loop = GeeksforGeeks
        Array printing using foreach loop = GeeksforGeeks

*/
