/*
   Source: https://www.geeksforgeeks.org/c-sharp-foreach-loop/
   Author: ankita_saini
   Summary: This simple program demonstrates the use of foreach loop.
   Date: 4 May 2019
   Modifications: ----

 */

using System;
class For_Each
{

    public static void Main(String[] arg)
    {
        {
            // The 'marks' variable is declared as an array
            // that holds int data types, with the numbers
            // below assigned to that array.
            int[] marks = { 125, 132, 95, 116, 110 };

            // The 'highest_marks' variable is declared an
            // int data type that is assigned to the result
            // returned from the maximum() method which will
            // carry out its specific function as it references
            // the 'marks' variable from above.
            int highest_marks = maximum(marks);

            Console.WriteLine("The highest score is " + highest_marks);
        }
    }
 
    public static int maximum(int[] numbers)
    {
        // The 'maxSoFar' variable is initially assigned
        // to the 1st array value of 'numbers'. Because the
        // Main() method is invoking the maximum() method
        // using 'marks' array within its parameter, the
        // 'numbers' array will be replaced by 'marks' array.
        // As a result, the value that will be initially
        // assigned to maxSoFar will be marks[0] or 125.
        int maxSoFar = numbers[0];

        // The foreach loop here will loop through each of
        // the int elements (which are the values of, in this
        // case, the 'marks' array, such as 125 and 132).
        foreach (int num in numbers)
        {
            // The condition statement will check to see if
            // the elements of 'num' is greater than the value
            // of 'maxSoFar.' When it returns true, the 'num'
            // value will replace maxSoFar's value. 
            if (num > maxSoFar)
            {
                maxSoFar = num;
            }
        }

        // After finishing the iteration, the program will
        // return the highest value it found as the 'maxSoFar'
        // which will be assigned to the 'highest_marks' in
        // the Main() method.
        return maxSoFar;
    }
}

/*      
        Example output:
        The higest score is 132

*/
