/*
   Source: https://www.sanfoundry.com/csharp-progam-string-sum-digits/
   Author: Manish Bhojasia
   Summary: This program accepts a character string, then adds all of
            the character’s integer value, thereby summing all the digits
            of a string.
   Date: 6 Apr 2019
   Modifications: ----

*/

using System;
class Program
{
    public static void Main()
    {
        // The program declares and initializes char type array that
        // stores 20 char elements. It then initializes int variables count,
        // nc, sum, n, and i in which nc and sum are asigned to 0.
        // The n variable is an int value that is assignted to an int
        // value converted from a string input.

        char[] string1 = new char[20];
        int count, nc = 0, sum = 0, n, i;
        Console.WriteLine("Enter the Length of the sentence  :");
        n = int.Parse(Console.ReadLine());

        // The for loop here will read each string from a second input and
        // convert them into a char type and store them into the string1[]
        // array. It will keep executing i++, converting a single string until
        // i < n. The array here will store each char values separately, i.e.,
        // input 3C, values 3 and C will be stored in string1 array.

        Console.WriteLine("Enter the string1 containing both digits and alphabet :");
        for (i = 0; i < n; i++)
        {
            string1[i] = Convert.ToChar(Console.Read());
        }

        // This second for loop will execute continuously for the values in the array
        // string1 that are now attributed to 'count' variable as long as the
        // char values do not return null character (!= '\0').
        for (count = 0; string1[count] != '\0'; count++)
        {
            
            // The if statement checks to see if the values in string1 are greater than
            // or equal to 0 AND less than or equal to 9 since the char values split
            // in the first for loop will either be a letter or a number. If the statement
            // returns true, the nc variable which was originally 0 will add 1. The sum
            // variable which was also 0, will now add the numeric values from the
            // string1 array. Both statements will execute until the condition returns
            // false.
            if ((string1[count] >= '0') && (string1[count] <= '9'))
            {
                nc += 1;
                sum += (string1[count] - '0');
            }
        }

        // The 'digits counted' is reflected by the variable nc while the sum
        // of 'digits found' within the converted string is assigned to the sum
        // variable. The {0} returns the respective variables that were
        // calculated in the process above since both variables are in the 1st
        // parameter of Console.WriteLine().
        Console.WriteLine("NO. of Digits in the string1 = {0}", nc);
        Console.WriteLine("Sum of all digits = {0}", sum);
        Console.ReadLine();
        Console.ReadLine();
    }
}

/*      Example Output:
        Enter the Length of the sentence  :
        6
        Enter the string1 containing both digits and alphabet :
        SAN193
        NO.of Digits in the string1 = 3
       Sum of all digits = 13
 */