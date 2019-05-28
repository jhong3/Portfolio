/*
   Source: https://www.sanfoundry.com/csharp-program-count-vowels-consonants/
   Author: Manish Bhojasia
   Summary: This program will take a sentence from user input
            and output the number of vowels and consonants.
   Date: 21 Apr 2019
   Modifications: ----
*/


using System;
class program
{
    public static void Main()
    {
        // The program assigns the 'sentence' variable
        // to a char array type which holds up to 100
        // elements.
        char[] sentence = new char[100];

        // Since the intent of the program is to count,
        // variables i, vowels, consonants, special, and
        // n are initialized as int data types with the
        // variables that will be 'counting' set to equal
        // 0.
        int i, vowels = 0, consonants = 0, special = 0, n;
        Console.WriteLine("Enter the Length of the sentence  \n");

        // The n variable will be used to determine the
        // length so it will need to use int.Parse() method
        // to convert the string to an int. The length
        // of the sentence here will read the number of
        // characters in the string, e.g. if the desired
        // string is 'cook', the length input will be 4.
        n = int.Parse(Console.ReadLine());

        // The for statement will be used to loop the method
        // within the block as it converts the input of each
        // string to a character using the sentence[] array
        // based on n length.
        for (i = 0; i < n; i++)
        {
            sentence[i] = Convert.ToChar(Console.Read());
        }

        // The second for loop is used to 'count' the specific
        // matching strings until as long as the program
        // continues to meet the condition and does not return
        // null ('\0').
        for (i = 0; sentence[i] != '\0'; i++)
        {
            // The if statement block is used to check if the vowels
            // and their uppercase forms fall within the sentence[]
            // array. Each time the condition is met, the vowels
            // variable will add 1 to itself.
            if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] ==
            'i' || sentence[i] == 'o' || sentence[i] == 'u') ||
            (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
            'I' || sentence[i] == 'O' || sentence[i] == 'U'))
            {
                vowels = vowels + 1;
            }

            // If the chars stored in the string[] array do not match
            // the specific conditions from above, the program counts
            // them as consonants except in the if case below. However,
            // because the string can contain other characters - such as
            // a space - a second if statement is used to count them.
            else
            {
                consonants = consonants + 1;
            }

            // 't' is a consonant so it was commented out.
            if (/*sentence[i] == 't' ||*/ sentence[i] == '\0' || sentence[i] == ' ')
            {
                special = special + 1;
            }
        }

        // The final consonants are calculated after removing the special
        // characters counted in the second if statement to print the
        // results.
        consonants = consonants - special;
        Console.WriteLine("No. of vowels {0}", vowels);
        Console.WriteLine("No. of consonants {0}", consonants);
        Console.ReadLine();
        Console.ReadLine();
    }
}

/*
        Example output:
        Enter the Length of the sentence
        3
        san
        No. of vowels 1
        No. of consonants 2

*/