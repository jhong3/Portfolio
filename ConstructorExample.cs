/*
   Source: https://www.dotnetperls.com/constructor
   Author: Sam Allen
   Summary: This program demonstrates how to use the Base
            keyword to allow the derived constructor to invoke
            the base class constructor.
   Date: 13 Apr 2019
   Modifications: ----

 */

using System;

public class Bird
{
    // The public class 'Bird' is created and the same
    // Bird constructor is created, accepting int data
    // types in its parameter and printing out the
    // value in its Console.WriteLine() method.

    // The '$' identifies the string expression as an
    // interpolated string, meaning items with
    // interpolated strings are replaced by the
    // expression results, i.e., ("String {0}", value)
    // can be changed to ($"String {value}").

    public Bird(int value)
    {
        Console.WriteLine($"Bird() called with {value}");
    }
}

public class Parrot : Bird
{
    // The Parrot class is a derived class from the base
    // Bird class and also has the 'Parrot' constructor
    // that invokes the Bird constructor from above
    // when a new instance of 'Parrot' is created.
    public Parrot(int value) : base(value)
    {
        Console.WriteLine($"Parrot called with {value}");
    }
}

class Program
{
    static void Main()
    {
        // A new instance of the Parrot class with integer
        // 450 is created and assigned to the variable
        // 'parrot'. The Parrot class' constructor will
        // print out the integer value in its method
        // result. However, it will also call the Bird
        // class' method as the base class constructor
        // is automatically invoked.
        Parrot parrot = new Parrot(450);
        Console.WriteLine(":::DONE:::");
    }
}

/*
        Example Output:
        Bird() called with 450
        Parrot called with 450
        :::DONE:::

*/