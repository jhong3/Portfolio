/*
   Source: https://www.sanfoundry.com/csharp-program-trim-string/
   Author: Manish Bhojasia
   Summary: This simple program demonstrates how String.Trim()
            method is used on a given string.
   Date: 21 Apr 2019
   Modifications: ----
*/

using System;
namespace trim
{
    class Program
    {
        static void Main(string[] args)
        {
            // The program assigns the 'CSHARP' string
            // to the variable 'myString' which includes
            // spaces in the entire string.
            string myString = "    CSHARP      ";
            System.Console.WriteLine("The String Before Trimming :" +
                                     "(" + myString + ")");

            // The program invokes the .Trim() method and
            // applies it to the 'myString' variable by
            // combining the two with a dot notation.
            System.Console.WriteLine("The String After Trimming :" +
                                     "(" + myString.Trim() + ")");
            Console.Read();
        }
    }
}

/*
            Example output:
            The String Before Trimming : (     CSHARP    )
            The String After Trimming : (CSHARP)

*/
