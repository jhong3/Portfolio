/*
   Source: https://www.geeksforgeeks.org/c-sharp-using-foreach-loop-in-arrays/
   Author: SoM15242
   Summary: This program returns the total number of occurrences of different
            elements in an array using the foreach loop.
   Date: 5 May 2019
   Modifications: ----

 */

using System;

class GFG
{

    // Main Method 
    public static void Main()
    {
        // A char type array is initialized with the variable
        // 's' with various elements going into the array.
        char[] s = {'1', '4', '3', '1',
                    '4', '3', '1', '4',
                                  '3'};

        // The variables 'm', 'n', and 'p', are declared
        // int data types and assigned to value 0 as they
        // will be used as counters for the number of
        // occurrences of specific elements.
        int m = 0, n = 0, p = 0;

        // The foreach loop will traverse through the 's' array,
        // looking for the char type 'g' variable ('1', '3', '4').
        foreach (char g in s)
        {
            // During the loop, when the program g variable
            // returns the element '1', the counter for 'm'
            // increases by one. The second else-if checks
            // to see if it comes across '4' returns true.
            // If it does, the counter for 'n' increases
            // by one. The final else statement adds one
            // to 'p' if elements other than '1' or '4'
            // are found in the loop.
            if (g == '1')
                m++;
            else if (g == '4')
                n++;
            else
                p++;
        }

        // 'm', 'n', and 'p' will now return the number
        // of times their respective elements were passed
        // during the foreach loop.
        Console.WriteLine("Number of '1' = {0}", m);
        Console.WriteLine("Number of '4' = {0}", n);
        Console.WriteLine("Number of '3' = {0}", p);
    }
}

/*      
        Example output:
        Number of '1' = 3
        Number of '4' = 3
        Number of '3' = 3

*/
