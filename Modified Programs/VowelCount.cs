/*
   Author: John Hong
   Summary: See original
   Date: 17 May 2019
   Modifications: Slightly expanded the program and created a
                  vowelCount() method rather than placing all
                  functions into a single Main() method.

 */
 
using System;

namespace CountVowels
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please enter a string: ");

            string response = Console.ReadLine().ToLower();          

            Console.WriteLine("The number of vowels: {0}", vowelCount(response));

        }

        // A method called vowelCount() is created where it takes
        // string data types and returns int value.
        public static int vowelCount(string input)
        {
            int counter = 0;
            
            foreach (char vow in input)
            {

                if (vow == 'a' || vow == 'e' || vow == 'i' || vow == 'o' || vow == 'u')
                {
                    counter++;
                }

            }
            return counter;
        }
            
    }
}
