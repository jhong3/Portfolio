/*
   Source: https://www.sanfoundry.com/csharp-program-frequency-is-sentence/
   Author: Manish Bhojasia
   Summary: This program demonstrates the number of times the word "is" appears in
            a string input by the user.
   Date: 6 Apr 2019
   Modifications: Shortened the code by employing a system method and added
                  a second input function so that the user can determine
                  a specific string type that needs to be counted.

*/

using System;
class program
{
    public static void Main()
    {
        // Because the modified code will now request which word the user
        // would like counted, a new string variable s2 is introduced.
        string s1;
        string s2;
        Console.WriteLine("Enter the String : ");
        s1 = Console.ReadLine();
        Console.WriteLine("Which word would you like counted?");
        s2 = Console.ReadLine();

        // Rather than creating a new class and invoking a function within the
        // class, a new int variable stringCount can be introduced into
        // the program. From here, we can use the String.Split method to
        // split the string into an array of strings.

        // The s1 (text) is split into the number of substrings (s2's or user
        // input). Because we want the program to actually count, the variable
        // stringCount is an int data type and we subtract 1 everytime a specific
        // string (s2) appears which will require the split method to be a
        // .Length. stringCount will now return the number of types s2 appears.

        int stringCount = (s1.Split(s2).Length - 1);
        Console.WriteLine(stringCount);
        Console.ReadLine();
    }
}

/*
        Example Output:
        Enter the String :
        Rose is a flower and is also a name
        Which word would you like counted?
        is
        2

*/