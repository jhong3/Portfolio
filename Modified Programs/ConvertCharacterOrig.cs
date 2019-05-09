/*
   Source: https://www.sanfoundry.com/csharp-program-convert-character-case/
   Author: Manish Bhojasia
   Summary: This simple program obtains user's character input and converts
            the case of the character.
   Date: 6 Apr 2019
   Modifications: ---

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace casechange
{
    class Program
    {
        static void Main(string[] args)
        {
            // The program initializes variables a and i to char and int, respectively.
            // It then reads the user's input for char and converts the string input
            // to a char.
            char a;
            int i;
            Console.WriteLine("Enter the Character : ");
            a = Convert.ToChar(Console.ReadLine());
            i = (int)a;

            // Using if and else if, the program determines whether the 'a' variable
            // is greater than or equal 65 and less than or equal to 90 using the AND
            // operator. If the condition is met, the program determines that the input
            // variable is an Upper Case letter and will capitalize it. Otherwise, the
            // else if statement is executed and will determine that the variable is
            // instead a Lower Case letter and print out a lower case variable.
           
           // The values are based on ASCII values in which A-Z are 65-90 while
           // a-z are 97-122.
            if (a >= 65 && a <= 90)
            {

                Console.WriteLine("The Character is : {0}", char.ToLower(a));

            }
            else if (a >= 97 && a <= 122)
            {
                Console.WriteLine("The Character is : {0}", char.ToUpper(a));
            }
            Console.ReadLine();
        }
    }
}

/*
    
   Example Output:
   
   Enter the Character : a
   The Character is : A

 */
