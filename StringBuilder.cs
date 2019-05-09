/*
   Source: https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/
   Author: ankita_saini
   Summary: This program illustrates the StringBuilder class
            and its invoked functions.
   Date: 5 May 2019
   Modifications: ----

 */

using System;
using System.Text;

class GFG
{
    public static void Main()
    {

        // The StringBuilder class declares the variable 's'
        // and initializes it by passing the string value
        // "Hello" and the capacity for the variable, 20.
        StringBuilder s = new StringBuilder("HELLO ", 20);

        // The .Append() method is invoked to append, or
        // add to the string value, returning "HELLO GFG".
        s.Append("GFG");

        // The .AppendLine() method is invoked to add to the
        // current string value and creates a new line at the
        // end of the string. "HELLO GFGGEEKS (new line)"
        s.AppendLine("GEEKS");

        // Once again, the .Append() method is called but since
        // the previous method created a new line, "GeeksForGeeks"
        // will be printed on a new line by itself.
        s.Append("GeeksForGeeks");
        Console.WriteLine(s);
    }
}

/*      
        Example output:
        HELLO GFGGEEKS
        GeeksForGeeks

*/
