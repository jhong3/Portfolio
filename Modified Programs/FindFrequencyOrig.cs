/*
   Source: https://www.sanfoundry.com/csharp-program-frequency-is-sentence/
   Author: Manish Bhojasia
   Summary: This program demonstrates the number of times the word "is" appears in
            a string input by the user.
   Date: 6 Apr 2019
   Modifications: ----

 */
using System;
class program
{
    public static void Main()
    {
        // In Main(), s1 variable is assigned to a string data type where
        // an input string from the user will be allocated.
        string s1;
        Console.WriteLine("Enter the String : ");
        s1 = Console.ReadLine();

        // The program writes out the number of times the word 'is'
        // appears by invoking the CountString.Occurrences() method
        // from counting class defined below.
        Console.WriteLine(counting.CountStringOccurrences(s1, "is"));
        Console.ReadLine();
    }
}
public static class counting
{
    public static int CountStringOccurrences(string text, string pattern)
    {
        // A class called counting is initialized in which only one function
        // is made - CountStringOccurrences(). This function takes two string
        // data types within its parameter. Using the while loop, the program
        // checks the value of IndexOf() - which counts the string 'pattern' -
        // to see if it does not equal -1.

        // If the condition returns true, the loop is executed in which i
        // is added to pattern.Length incrementally until there are no more
        // 'patterns' left, i.e. the program will count the number of 'is' that
        // appears in the text "Rose is a Flower". For every 'is' that appears
        // in the string, the program will add (count++) 1 to the i variable until
        // there are no more 'is' left in the text.
        int count = 0;
        int i = 0;
        while ((i = text.IndexOf(pattern, i)) != -1)
        {
            i += pattern.Length;
            count++;
        }
        return count;
    }
}

/*   
     Example Output:
     Enter the String :
     Rose is a Flower
     1

*/