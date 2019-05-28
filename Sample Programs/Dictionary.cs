/*
   Source: https://www.dotnetperls.com/dictionary
   Author: Sam Allen
   Summary: This sample program collects keys and
            values pairs of data and checks to see
            if the given string is in the Dictionary
            using ContainsKey function.
   Date: 20 Apr 2019
   Modifications: ----

*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // A new dictionary variable is declared with <string, int>
        // parameters and using .Add function. The keys 'apple' and
        // 'windows' paired with values 1 and 5, respectively, are
        // stored into a Dictionary.
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        dictionary.Add("apple", 1);
        dictionary.Add("windows", 5);

        // The if statement checks to see if 'apple'
        // key is contained in the dictionary. If true,
        // the value of the apple key is printed which is 1.
        if (dictionary.ContainsKey("apple"))
        {
            int value = dictionary["apple"];
            Console.WriteLine(value);
        }

        // The second if statement checks to see
        // if 'acorn' is stored in the dictionary
        // but is phrased: if dictionary does not
        // contain 'acorn' key'. Since the statement
        // is true, it will print false.
        if (!dictionary.ContainsKey("acorn"))
        {
            Console.WriteLine(false);
        }
    }
}

/*
        Example Output:
        1
        False

*/