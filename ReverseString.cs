/*
   Source: https://www.sanfoundry.com/csharp-program-reverse-string-without-reverse-function/
   Author: Manish Bhojasia
   Summary: This program reverses an input string without
            using a .Reverse() function
   Date: 4 May 2019
   Modifications: ----

 */

using System;
class Program
{
    static void Main(string[] args)
    {
        // The program declares string data type to the
        // variables "Str" and "reversestring" with
        // the latter variable assigned to empty "", and
        // "Length" variable as int type.
        string Str, reversestring = "";
        int Length;
        Console.Write("Enter A String : ");

        // The program assigns the input string as the
        // value for "Str" variable.
        Str = Console.ReadLine();

        // The "Length" variable will subtract 1 depending
        // on the value returned from the numeric value of
        // the input string's length, i.e., if the input
        // string is "can", the Str.Length will return
        // the value 3 and the Length will return 2.
        Length = Str.Length - 1;

        // The while loop will continue to execute until the
        // condition (>=0) no longer returns true.
        while (Length >= 0)
        {
            // Inside the while loop block, the "reversestring"
            // variable's "" will initially concatenate with
            // the last position of the string of the "Str" variable.
            // Then it will subtract 1 from the Length value,
            // and execute the loop again if the condition is true.

            // If the input was "can", the Length value will
            // return the value 2. The reversestring will first
            // return empty "" + the third position in the Str
            // array, which is the letter n. Then the program
            // will subtract 1 from 2, to return the value 1 for
            // Length while reversetring will return the string 'n'.
            // The loop will execute again since the Length is 1,
            // which will take the second element (a) of the Str array
            // (since arrays count first position as 0) and
            // concatenate with 'n', returning 'na'. The loop will
            // execute once more and concatenate 'na' with first
            // element (Str[0]) which is the string 'c'. Once
            // reversestring return "nac" it will break from the
            // loop since the Length will now be negative.
            reversestring = reversestring + Str[Length];
            Length--;
        }
        Console.WriteLine("Reverse  String  Is  {0}", reversestring);
        Console.ReadLine();
            
    }
}

/*      
        Example output:
        Enter a String : Candy
        Reverse String Is ydnaC

*/
