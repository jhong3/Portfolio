/*
   Source: https://www.dotnetperls.com/linq
   Author: Sam Allen
   Summary: This program demonstrates LINQ expression
            using Enum
   Date: 17 Apr 2019
   Modifications: ----
 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // After storing a set of integers into an array,
        // a LINQ query expression is used to retrieve
        // the values. With int variables now inside the
        // var 'elements', the query takes from 'element'
        // that is in the variable 'array', orders the
        // 'element' values greater than 2 in descending
        // order.
        int[] array = { 1, 2, 3, 6, 7, 8 };
        var elements = from element in array
                       orderby element descending
                       where element > 2
                       select element;
        // With Enum in foreach loop, an 'element'
        // is a variable (number) within a group of
        // 'elements' and will print out variables
        // greater than 2 from greatest value to least.
        foreach (var element in elements)
        {
            Console.Write(element);
            Console.Write(' ');
        }
        Console.ReadLine();
    }
}

/* Example Output:
  
   8 7 6 3
  
*/