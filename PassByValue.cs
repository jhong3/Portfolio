/*
   Source: https://www.sanfoundry.com/csharp-program-pass-by-value-parameter/
   Author: Manish Bhojasia
   Summary: This program demonstrates a copy of the variable being passed to
            the method without affecting the original data.
   Date: 5 May 2019
   Modifications: ----

 */

using System;
class program
{
    // The Cube method accepts int data types of variable x in its
    // parameters. Its function is shown as x times itself 3 times
    // and returns the value of 'new' variable x as it's printed
    // in the console.
    static void Cube(int x)
    {
        x = x * x * x;
        Console.WriteLine("Value Within the Cube method : {0}", x);
    }
    static void Main()
    {
        // Here, the num variable is an int data type assigned to
        // value 5. The Console.WriteLine() parameters will pass the
        // value and print it to the console.
        int num = 5;
        Console.WriteLine("Value Before the Method is called : {0}", num);

        // The Cube() method is executed with the variable num taking
        // the place of variable x and performing the calculations. The
        // num value will be originally 5, but after Cube() method is
        // executed, the value of x or num of the function will be 125.
        Cube(num);

        // The value of num will still return 5 because the value was
        // merely passed to the Cube() method and calculated. It does
        // not affect the original value of num.
        Console.WriteLine("Value After the Method is called : {0}", num);
        Console.ReadKey();
    }
}

/*      
        Example output:
        Value Before the Method is called : 5
        Value Within the Cube method : 125
        Value After the Method is called : 5

*/
