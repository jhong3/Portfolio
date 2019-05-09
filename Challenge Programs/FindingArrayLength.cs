/*
   Source: John Hong
   Author: John Hong
   Summary: This simple program finds the length of 
            an array without calling the .Length function.
   Date: 5 May 2019
   Modifications: 

 */

using System;
class FindingArrayLength
{
    static void Main(string[] args)
    {
        // The int type array is initialized with the
        // 'array' variable with various int elements.

        int[] array = { 10, 5, 25, 29, 55 };

        // The foreachcount variable will be used to count
        // the number of elements the program passes
        // during the foreach loop.
        int foreachcount = 0;
        
        // The foreach loop will traverse through each
        // 'element' variable inside the 'array' array
        // and will add 1 to the 'foreachcount' variable
        // every time it encounters an element.
        foreach (int element in array)
        {
            foreachcount++;
        }

        // The 'shortcut' variable is implemented to confirm
        // that the foreach loop correctly found the length.
        int shortcut = array.Length;
        
        Console.WriteLine("Array length found using Foreach Loop: {0}", foreachcount);
        Console.WriteLine("Array length found using .Length function: {0}", shortcut);
        Console.ReadLine();

        // Foreach is useful for finding the length of an
        // array (if prohibited from using .Length)
        // especially when the number of elements in an
        // array can change.
    }
}

/*      
        Example output:
        Array length found using Foreach Loop: 5
        Array length found using array.Length function: 5

*/
