/*
   Source: https://bit.ly/practicewhiteboard
   Author: Epicodus
   Summary: This is a challenge problem focusing on loops, arrays, and
            basic C# operators. Shortcut functions, .Length and .Sum
            will not be used.

   Problem: Write a method that takes in two arrays of integers.
            The method should sum the value of the integers in
            both arrays and calculate the average (mean) value
            of the integers. The method should return this value
            as an integer. The method should handle arrays that
            contain negative and non-negative integers.

            - Given: [5, 1, 4, -9, 3], [2, 4, -2]
            - Output: 1

            Special note: When division between two integers results
                          in a fraction, the decimal value is
                          truncated, not rounded, i.e., 5/2 = 2.
   
   Date: 5 May 2019
   Modifications: ---

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class WhiteBoardSampleChallenge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given the arrays: \n" +
                              "[5, 1, 4, -9, 3] and [2, 4, -2]");

            // The array1 and array2 are initialized
            // as int type arrays, with each assigned
            // to specific int values.
            int[] array1 = { 5, 1, 4, -9, 3 };
            int[] array2 = { 2, 4, -2 };

            // The four variables are initially assigned
            // to value 0 as they will be used to calculate
            // the array lengths and sum of the elements
            // of an array in a loop.
            int array1Length = 0, array2Length = 0;
            int sum1 = 0, sum2 = 0;


            // Avoiding the array.Length function, the
            // foreach statement is used instead to loop
            // through array1 and array2 to count the number
            // of elements within each respective arrays.
            foreach (int element in array1)
            {
                array1Length++;
            }

            foreach (int element in array2)
            {
                array2Length++;
            }

            // Avoiding .Sum function, for-loop is used instead
            // to find the sum of the elements of each array.
            // The length of the arrays were calculated using
            // the foreach from above and are now used in the
            // for-loop iteration. The sum variables will
            // continuously add the elements until the iteration
            // breaks.


            for (int i = 0; i < array1Length; i++)
            {
                sum1 += array1[i];
            }

            for (int i = 0; i < array2Length; i++)
            {
                sum2 += array2[i];
            }

            // With the sums of each arrays assigned to variables
            // 'sum1' and 'sum2', the total value is calculated
            // using 'TotalSum' variable. The 'TotalLength'
            // is calculated after finding the values for
            // the arrays' lengths during the foreach loops.
            // Finally, the average is calculated with all of the
            // values.

            int TotalSum = sum1 + sum2;
            int TotalLength = array1Length + array2Length;
            int Mean = TotalSum / TotalLength;

            Console.WriteLine("The average of the two arrays is: {0}", Mean);
            Console.ReadKey();

        }

    }
}

/*      
        Example output:
        Given the arrays:
        [5, 1, 4, -9, 3] and [2, 4, -2]
        The average of the two arrays is: 1
       

*/
