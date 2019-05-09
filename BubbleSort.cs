/*
   Source: https://www.sanfoundry.com/csharp-program-bubble-sort/
   Author: Manish Bhojasia
   Summary: This program demonstrates the bubble sort algorithm
            by sorting the values of an array in increasing
            order.
   Date: 5 May 2019
   Modifications: Changed " " string to "\n" to display intended
                  output.

 */

using System;
class bubblesort
{
    static void Main(string[] args)
    {
        // An int type array is initialized with the variable
        // 'a' and assigned with various integers.
        int[] a = { 3, 2, 5, 4, 1 };
        int t;
        Console.WriteLine("The Array is : ");

        // The for-loop will iterate through each element
        // within the array and print out each element
        // until 'i' is less than the total number of
        // elements.
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        // The second for-loop will now loop through 'j'
        // times until j <= a.Length-2 is not true. This
        // outer loop will be used to pass through the
        // array starting from the end of the element, i.e.,
        // 4 and 1 will be the first pass.
        for (int j = 0; j <= a.Length - 2; j++)
        {

            // The inner for-loop will be used to execute
            // the if statement below. Since the outer loop
            // will pass the values 4 and 1, they will be
            // compared by the if statement.
            for (int i = 0; i <= a.Length - 2; i++)
            {
                // The condition statement will compare the value
                // of the current variable with the subsequent
                // variable. If it's true, the code block will
                // execute, where 't' is the temporary value and
                // will swap position with the next variable. In
                // the case of 4 and 1, the program will switch
                // places of the two elements.
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            }

            // Once the condition statement is evaluated, the result will
            // be 3, 2, 5, 1, 4. The inner for-loop will execute again,
            // now comparing 5 and 1. This will continue until 1 reaches
            // the 0th place in the array, i.e. 1, 3, 2, 5, 4. When it
            // does, it will complete the first pass. Now the outer loop
            // will execute a second pass, starting with 5 and 4, and the
            // entire compare/swap process starts again. Given that there
            // are 5 total elements, the algorithm will have total of 4
            // passes until the values are in order.

        }
        Console.WriteLine("The Sorted Array :");

        // The foreach will now take the sorted 'a' array and print
        // the int values of the 'aray' variables.
        foreach (int aray in a)
        Console.Write(aray + "\n");
        Console.ReadLine();
    }
}

/*      
        Example output:
        The Array is :
        3
        2
        5
        4
        1
        The Sorted Array :
        1
        2
        3
        4
        5

*/
