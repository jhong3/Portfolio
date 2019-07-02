/* 
   Problem: Write a program that outputs percentage of palindrome
            words in a given string, e.g. "taco nacho cat" = 66.67%
                      y     n     y
             since "taco | nach|o cat" (2/3)
  
   Summary: This program finds the percentage of palindrome
            words in a given string. It currently is a WIP.
            
            Also included isPalindrome method that checks if
            a given string is a palindrome.
 
   Student: John Hong 
    
 */


using System;

namespace PalindromePercent
{
    class Program
    {
        static void Main()
        {
            // In the given test 2 string, the percentage of palindrome words is ~66.67%
            //          y     n     y
            // since "taco | nach|o cat" (2/3).


            string test1 = "taco cat"; // isPalindrome
            string test2 = "taco nacho cat"; // 2/3
            string test3 = "taco taco nacho cat ocat"; // 4/5
            //Console.WriteLine(isPalindrome(yPali));
            Console.WriteLine(PalindromePercent(test3) + "%");

        }

        static bool isPalindrome(string input)
        {
            // variable to create reversed string
            string reversed = "";
            string deleteSpace = input.Replace(" ", ""); // Replace method for strings with ' '

            // Iterate backwards, store reversed characters
            for (int i = deleteSpace.Length - 1; i >= 0; i--)
            {
                reversed += deleteSpace[i];
            }

            // check if strings are equal
            if (reversed == deleteSpace)
                return true;
            else
                return false;
        }
        
        static double PalindromePercent(string input)
        {
            string removedStartandEndSpace = input.Trim(); // Edge cases where there may be space at start and end

            int totalWords = 1; // starting at 1 because total number of words can be determined by # of spaces + 1,
                                // i.e. "cat dog" = 2 words (1(space) + 1), "Ed bed led" = 3 words (2 + 1), etc.

            foreach (var element in removedStartandEndSpace)
                if (element == ' ')
                    totalWords++;

            // Replace space char with empty string to get "taconachocat"
            string shorter = removedStartandEndSpace.Replace(" ", "");

            // Using mid to traverse halfway.
            int mid = (shorter.Length - 1) / 2;

            double paliCounter = 0;

            // If the string is already a palindrome, then it's 100%
            if (isPalindrome(input))
                paliCounter = totalWords;

            else
                // Compare start value and end value until it reaches the middle.
                for (int i = 0; i <= mid; i++)
                {
                    if (shorter[i] != shorter[shorter.Length - i - 1])
                    {
                        // If the front and end don't match during iteration, at
                        // least 2 palindrome words were found. Counter can't
                        // exceed total number of words.
                        paliCounter += 2;
                        if (paliCounter > totalWords)
                            paliCounter -= 2;
                        if (paliCounter == totalWords)
                            break;
                    }
                    
                } 

            return (paliCounter / totalWords) * 100;
        }

    }
}
