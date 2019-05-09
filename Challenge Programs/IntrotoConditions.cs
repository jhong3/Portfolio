/*
   Source: https://www.hackerrank.com/challenges/30-conditional-statements/problem
   Author: aa1992
   Summary: This is an introductory program demonstrating conditional statements.
   Problem: Given an integer, N, perform the following conditional actions:

            If N is odd, print Weird
            If N is even and in the inclusive range of 2 to 5, print Not Weird
            If N is even and in the inclusive range of 6 to 20, print Weird
            If N is even and greater than 20, print Not Weird

   Date: 4 Apr 2019
   Modifications: Added additional string asking for user input, replaced
                  original answer with a while loop to account for possible
                  end-user error.

 */

using System;

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");

        // The variable 'N' is declared an int data type and assigned
        // to the user's input string which is converted into an int
        // data type.

        //int N = Convert.ToInt32(Console.ReadLine());

        // The while loop will execute if the user input throws an exception,
        // and will continue to throw the error message until a valid string
        // that represents an integer is entered.

        int N;
        while (!int.TryParse(Console.ReadLine(), out N))
        {
            Console.WriteLine("Invalid input, please enter a valid number : ");
        }

        // The outer conditional statement checks to see if the input
        // value does not return a remainder when divided by 2. This
        // is to check if the value is even. If the condition is true,
        // the inner if-else statements are executed.
        if ((N % 2) == 0)
        {
            // The second if statement checks to see if the input value
            // is greater than or equal to 2 AND the value is less than
            // or equal to 5 OR N is greater than 20. If the condition
            // returns true, the program will print "Not Weird."
            if (N >= 2 && N <= 5 || N > 20)
            {
                Console.WriteLine("Not Weird");
            }

            // When the condition returns false (not meeting the
            // conditions above), the program returns "Weird."
            else
            {
                Console.WriteLine("Weird");
            }
        }

        // If the condition returns false (N/2 returns a
        // remainder indicating that N is an odd number),
        // the program prints "Weird."
        else
        {
            Console.WriteLine("Weird");
        }

        Console.ReadKey();
    }
}

/*      
        Example output:
        Enter a number:
        G
        Invalid input, please enter a valid number :
        5
        Weird
       
*/
