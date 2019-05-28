/*
   Source: https://www.geeksforgeeks.org/sorteddictionary-class-in-c-sharp/
   Author: ankita_saini
   Summary: This is a program demonstrates the concept of
            SortedDictionary<TKey, TValue>().
   Date: 3 May 2019
   Modifications: ---

 */

using System;
using System.Collections.Generic;

public class GFG
{

    static public void Main()
    {

        // A new instance of SortedDictionary class that accepts
        // two string data is created with 'myDr' variable.
        SortedDictionary<string, string> myDr =
          new SortedDictionary<string, string>();

        // The .Add function adds two string pairs, the first string
        // being the key and the second string assigned to value.
        myDr.Add("One", "C");
        myDr.Add("Two", "C++");
        myDr.Add("Three", "C#");

        // Using foreach loop, the program will go through each
        // key/value pairs and print the respective strings.
        // The program will print alphabetically so "Three and
        // Value: C# will print before "Two and Value: C++"
        // because the SortedDictionary class are sorted by
        // the Key.
        foreach (KeyValuePair<string, string> pair in myDr)
        {
            Console.WriteLine("Key: {0} and Value: {1}",
                                  pair.Key, pair.Value);
        }
    }
}

/*      
        Example output:
        Key: One and Value: C
        Key: Three and Value: C#
        Key: Two and Value: C++
       
*/
