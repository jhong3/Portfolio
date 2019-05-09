/*
   Source: https://www.geeksforgeeks.org/c-sharp-list-class/
   Author: Kirti Mangal
   Summary: This program illustrates the Capacity Property
            of List<T>. Capacity is the number of elements
            that the List<T> can store before resizing and
            Count is the number of elements that are
            actually stored in List<T>.
   Date: 22 Apr 2019
   Modifications: ----

 */

using System;
using System.Collections.Generic;

class Geeks
{

    // Main Method 
    public static void Main(String[] args)
    {

        // A List of integers are created for the
        // firstlist variable.
        List<int> firstlist = new List<int>();

        // The program adds four elements
        // to the list.
        firstlist.Add(1);
        firstlist.Add(2);
        firstlist.Add(3);
        firstlist.Add(4);


        // The first two Console.WriteLine()'s shows
        // the list's current Capacity and Count.
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);

        Console.WriteLine("Count Is: " + firstlist.Count);

        firstlist.Add(5);
        firstlist.Add(6);

        // After adding two new elements to the list, the
        // Capacity will return 8 because internally, the
        // size had been implicitly changed. However,
        // the Count function will display 6 because the
        // list only added two more elements.
                
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);
        Console.WriteLine("Count Is: " + firstlist.Count);


        // If 2 more elements were added, the capacity will
        // still return 8 and the count would also return 8.
        // If 3 were added instead of 2, then the capacity will
        // internally resize again and return 16.
    }
}

/*
        Example output:
        Capacity Is: 4
        Count Is: 4
        Capacity Is: 8
        Count Is: 6

*/