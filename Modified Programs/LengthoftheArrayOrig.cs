/*
   Source: https://www.sanfoundry.com/csharp-program-length-array/
   Author: Manish Bhojasia
   Summary: This program retrieves the length of an array.
   Date: 5 Apr 2019
   Modifications: ----

 */
using System;
class Program
    {
        static void Main()
        {
            // The arrayA is declared and initialized to an int type
            // that stores 5 int value. However, values are not assigned.
            int[] arrayA = new int[5];
            int lengthA = arrayA.Length;
            Console.WriteLine("Length of ArrayA : {0}", +lengthA);
            long longLength = arrayA.LongLength;
            Console.WriteLine("Length of the LongLength Array  : {0}", longLength);
            
            // twoD array is defined and initialized to an int type array
            // that is two-dimensional and is given 5 rows and 10 columns.
            // The .Length then calculates the length, giving 50 as the result.
            int[,] twoD = new int[5, 10];
            Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
            Console.ReadLine();
        }
    }

/*
            Original Output:
            Length of ArrayA : 5
            Length of the LongLength Array is : 5
            The Size of 2D Array is : 50

*/