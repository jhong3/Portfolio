/*
   Source: https://www.dotnetperls.com/dictionary
   Author: Sam Allen
   Summary: This sample program takes a defined
            array of strings and removes redundant
            strings.
   Date: 20 Apr 2019
   Modifications: ----

*/

using System;
using System.Collections.Generic;

class HashSetDuplicateRemoval
{
    public static List<string> RemoveDuplicatesSet(List<string> items)
    {
        // The var type result variable is declared into a new
        // List with string values. The set variable uses
        // HashSet that also holds string values.
        var result = new List<string>();
        var set = new HashSet<string>();

        // The for loop will execute continuously until
        // i is less than the items variable count. The
        // items are the strings that are entered into
        // the for loop.
        for (int i = 0; i < items.Count; i++)
        {
            // The if statement checks to see if
            // the set variable does not contain string
            // items. If the condition is met, it adds
            // to the result variable's List. However,
            // once that string contains the same string,
            // it will not execute the if statement.
            if (!set.Contains(items[i]))
            {
                result.Add(items[i]);
                
                // When the if statement is true, the variable
                // set with HashSet is invoked with .Add function.
                // This part of the method stores the strings that
                // are read by the program.
                set.Add(items[i]);
            }
        }
        return result;
    }

    static void Main()
    {
        var input = new List<string>() { "a", "b", "a", "b", "b", "b", "c" };

        // The program adds a list of strings and stores them into
        // variable input. The output variable retrieves its value
        // after employing the RemoveDuplicatesSet() method.
        var output = RemoveDuplicatesSet(input);
        
        Console.WriteLine("Input: " + string.Join(",", input));
        Console.WriteLine("Output: " + string.Join(",", output));
    }
}

/*
        Example Output:
        Input: a,b,a,b,b,b,c
        Output: a,b,c

*/
