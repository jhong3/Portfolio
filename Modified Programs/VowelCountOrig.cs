/*
   Source: ---
   Author: John Hong
   Summary: This program counts the number of vowels, including
            uppercase letters.
   Date: 17 May 2019
   Modifications: ----

 */


using System;

namespace CSC395_Module01_HW1a
{
    class Program
    {
        static void Main()
        {
            // The Console.WriteLine() method will print out
            // a string message requesting user input.
            Console.WriteLine("Please enter a string: ");

            // Here, the 'response' variable is declared as
            // a string data type and simultaneously assigned
            // to the string value taken from user input which
            // is also converted to lower case.
            string response = Console.ReadLine().ToLower();

            // The 'counter' variable is declared as an int
            // data type and will be used to count the number
            // of vowel occurences, so it is initially assigned
            // to the value 0.
            int counter = 0;

            // The foreach loop will iterate through each
            // char 'vow' variable from the 'response' string,
            // e.g., if the user input is "Hey", the foreach
            // will go through "H", "e", and "y".
            foreach (char vow in response)
            {
                // The if statement will check to see if the char
                // 'vow' matches any of the following vowels during
                // its iteration. If it does, the counter variable
                // will increase by 1. Rather than having repeating
                // if-else statements, the conditional statement was
                // condensed and fit into a single if statement using
                // the || operator (OR).
                if (vow == 'a' || vow == 'e' || vow == 'i' || vow == 'o' || vow == 'u')
                {
                    counter++;
                }

            }

            // Once the foreach loop ends, the counter variable
            // will now have the number of times the condition
            // was met and will return the numeric value, which
            // is used in the Console.WriteLine() method to
            // display it.
            Console.WriteLine("Number of vowels: {0}", counter);


        }
    }
}


