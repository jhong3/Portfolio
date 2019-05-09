/*
   Source: https://www.sanfoundry.com/csharp-program-length-array/
   Author: Manish Bhojasia
   Summary: This program retrieves the length of an array.
   Date: 5 Apr 2019
   Modifications: Modified program requesting user input

 */

using System;
class Program
{
    static void Main()
    {
        // Instead of hardcoding variables for the array,
        // the program now requests input from the user.
        Console.WriteLine("Input Custom Length for ArrayA: ");

        // Using the int.Parse() method, the program will take
        // the string from the user and convert it to an int
        // value.
        int[] arrayA = new int[int.Parse(Console.ReadLine())];
        int lengthA = arrayA.Length;

        long longLength = arrayA.LongLength;

        Console.WriteLine("Input 2 numeric values for 2D Array: ");

        // twoD will require two separate int.Parse(Console.ReadLine())'s
        // in its parameter because int[,] defined that it was 2
        // dimensional.
        int[,] twoD = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

        Console.WriteLine("Length of ArrayA : {0}", +lengthA);
        Console.WriteLine("Length of the LongLength ArrayA  : {0}", longLength);
        Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);

        Console.ReadLine();
    }
}

/*
        Modified Output:
        
        Input Custom Length for ArrayA: 
        10
        Input 2 numeric values for 2D Array:
        3
        6
        Length of ArrayA : 10
        Length of the LongLength Array is : 10
        The Size of 2D Array is : 18

*/