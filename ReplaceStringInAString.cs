/*
   Source: https://www.sanfoundry.com/csharp-program-replace-string/
   Author: Manish Bhojasia
   Summary: This simple program demonstrates an instance where
            a string is replaced with a different string.
   Date: 19 Apr 2019
   Modifications: ----

*/

using System;
class Program
{
    static void Main()
    {
        // The 's' variable is assigned as a string data type and
        // also as a constant member to prevent 's' from being
        // changed during runtime.
        const string s = "Sun Rises in the West";

        // The {0} indicates that the program will insert the 1st
        // and only parameter, the variable 's'. As a result, the
        // console will print "Sentence Before Replacing : Sun Rises
        // in the West."
        Console.WriteLine("Sentence Before Replacing : {0} ", s);

        // The 's1' variable is also assigned to a string data type
        // because it will be returning the same string as variable
        // 's' except it will be using the .Replace() function to
        // replace the 'West' string with 'East' string. And since
        // this is a new variable and 's' was declared a constant,
        // the new 's1' variable is used for the first parameter to
        // display the replaced string.
        string s1 = s.Replace("West", "East");
        Console.WriteLine("Sentence After Replacing : {0} ", s1);
        Console.ReadLine();
    }
}
/*
        Example Output:
        Sentence Before Replacing : Sun Rises in the West
        Sentence After Replacing : Sun Rises in the East
 */