/*
   Source: https://www.sanfoundry.com/csharp-program-combine-delegate/
   Author: Manish Bhojasia
   Summary: This program demonstrates how once a delegate is declared,
            it assumes the role of a pointer.
   Date: 20 Apr 2019
   Modifications: ----

*/

using System;


// Delegates after this declaration will be used to
// reference any method that contains a single
// string parameter but will not return any variables
delegate void dele(string s);
class TestClass
{
    static void Good(string s)
    {
        System.Console.WriteLine("  Good, {0}!", s);
    }

    static void Morning(string s)
    {
        System.Console.WriteLine("  Morning, {0}!", s);
    }

    static void Main()
    {
        // firstdel, secondDel, multiDel, multiMinusfirstdel
        // are declared as delegates and each respective
        // delegates reference methods Good and Morning or
        // combinations of other delegates employing the methods.

        // The program assigns A, B, C, and D to each respective
        // delegates and will print out combinations of Good and
        // Morning methods to show that they are acting as
        // references for the program.

        dele firstdel, secondDel, multiDel, multiMinusfirstdel;
        firstdel = Good;
        secondDel = Morning;
        multiDel = firstdel + secondDel;
        multiMinusfirstdel = multiDel - firstdel;
        Console.WriteLine("Invoking delegate firstdel:");
        firstdel("A");
        Console.WriteLine("Invoking delegate secondDel:");
        secondDel("B");
        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");
        Console.WriteLine("Invoking delegate multiMinusfirstdel:");
        multiMinusfirstdel("D");
        Console.ReadLine();
    }
}

/*
        Example Output:
        Invoking delegate firstDel:
        Good, A!
        Invoking delegate SecondDel:
        Morning, B!
        Invoking delegate multiDel:
        Good, C!
        Morning, C!
        Invoking delegate multiMinusFirstDel:
        Morning, D!

*/