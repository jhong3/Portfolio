/*
   Source: https://www.geeksforgeeks.org/anonymous-method-in-c-sharp/
   Author: ankita_saini
   Summary: This program illustrates the anonymous method.
   Date: 5 May 2019
   Modifications: ----

 */

using System;

class GFG
{

    // A delegate that accepts string data type,
    // 'pet', variable is declared.
    public delegate void petanim(string pet);

    static public void Main()
    {
        // The 'fav' variable is assigned to the "Rabbit" string.
        string fav = "Rabbit";


        // Using the delegate petanim from above, an anonymous
        // method that has one parameter is created.
        petanim p = delegate (string mypet)
        {
            Console.WriteLine("My favorite pet is {0}.", mypet);

            // The outer variable, 'fav', can be accessed
            // by the anonymous method. 
            Console.WriteLine("And I like {0} also.", fav);
        };

        // The unnamed method is invoked here, assigning "Dog"
        // string to the 'mypet' variable.
        p("Dog");

    }
}

/*      
        Example output:
        My favorite pet is Dog.
        And I like Rabbit also.

*/
