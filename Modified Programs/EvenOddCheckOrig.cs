/*
   Source: https://www.sanfoundry.com/csharp-program-check-given-number-even-odd/
   Author: Manish Bhojasia
   Summary: This program determines if the user's input is odd or even.
   Date: 5 Apr 2019
   Modifications: ---

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {

            // The program assigns the variable 'i' with the int data type
            // since its function is to collect a numeric value from
            // the user.
            int i;
            Console.Write("Enter a Number : ");

            // The int.Parse method allows user's input (Console.ReadLine)
            // to be converted from a string to an int data type. The
            // conditional if checks to see if the input value does not
            // return a remainder (or equals 0) when divided by 2. If the
            // condition is not met, the else statement executes, indicating
            // that the value is an odd number.
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}

/*
       Original Output:
       
       User Input: 5
       Entered Number is an Odd Number

*/
