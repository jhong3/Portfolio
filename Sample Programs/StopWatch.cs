/*
   Source: https://www.sanfoundry.com/csharp-program-stopwatch/
   Author: Manish Bhojasia
   Summary: This program shows a simple way to create a stop
            watch timer to display the time it takes for
            a loop to execute. This is a useful program that
            can be implemented into other programs to check
            for performance and code optimization.
   Date: 21 Apr 2019
   Modifications: ----

 */

using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main()
    {
        // The variable 'stopwatch' is assigned
        // to a new Stopwatch class. The Stopwatch
        // class is a prebuilt function invoked from
        // System.Diagnostics.
        Stopwatch stopwatch = new Stopwatch();
        
        // Now that the stopwatch variable is assigned
        // to Stopwatch class, it can invoke .Start()
        // function within the class. Following after
        // the start of the function, the for loop
        // statement is executed (10 times) until it
        // returns false.
        stopwatch.Start();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("HI");
        }

        // Once the for loop ends, the program calls
        // the .Stop() function. The time it took for
        // the for loop to execute is displayed using
        // the .Elapsed notation.
        stopwatch.Stop();
        Console.WriteLine("Time Elapsed : {0}",
                           stopwatch.Elapsed);
        Console.ReadLine();
    }
}
/*    
        Example Output:
        HI
        HI
        HI
        HI
        HI
        HI
        HI
        HI
        HI
        HI
        Time Elapsed : 00:00:00.0070608

 */