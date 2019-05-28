/*
   Source: https://www.sanfoundry.com/csharp-programs-generate-factors/
   Author: Sam Allen
   Summary: This program finds the factors of an input number.
   Date: 5 May 2019
   Modifications: ----

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // The variables 'num' and 'x' are declared as
            // int data types as the former will be used to
            // convert a string to an int while the latter
            // will be used in for-loop.
            int num, x;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");

            // The for-loop here will loop 'x' number
            // of times until 'x' is greater than or equal
            // to the value of the input 'num', e.g. if the
            // input is 3, loop will iterate 3 times. The value
            // of x is assigned to 1 because the if statement
            // below will return an divide by zero exception when
            // 'x' is 0. The value of 'x' has to be less than or
            // equal to 'num' since the condition below will
            // continue to divide incrementally.
            for (x = 1; x <= num; x++)
            {
                // The if statement will check to see if the condition
                // is true, i.e., is the remainder of a given number
                // divided by 'x' equal 0? When it's true, the
                // program will print out the value of 'x'.
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();

        }
    }
}

/*      
        Example output:
        Enter the Number 
        25
        The Factors are : 
        1
        5
        25

*/
