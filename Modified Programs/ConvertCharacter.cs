/*
   Source: https://www.sanfoundry.com/csharp-program-convert-character-case/
   Author: Manish Bhojasia
   Summary: This simple program obtains user's character input and converts
            the case of the character.
   Date: 6 Apr 2019
   Modifications: Added bool keyword with new variable 'input' and Char.IsUpper
                  while deleting variable i and the conditional value ranges
                  for variable a.

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
            bool input;

            Console.WriteLine("Enter the Character : ");
            char a = Convert.ToChar(Console.ReadLine());


            // Rather than having the program check specifically to see if the user
            // input matches a specific range, it is simpler to check if the input's
            // case is uppercase or not using the Char.IsUpper() function.

            // This allows the code to be condensed without needing i's function.
            // Since Char.IsUpper() checks if the value of 'input' returns
            // true or false, the keyword bool is declared for variable input.
            if (input = Char.IsUpper(a))
            {
                Console.WriteLine("The Character is : {0}", char.ToLower(a));
            }
            else
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