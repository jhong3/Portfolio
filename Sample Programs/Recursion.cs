/*
   Source: https://www.geeksforgeeks.org/recursion/
   Author: Anshul Aggarwal (C# tab)
   Summary: This program demonstrates recursion, process
            in which the function calls itself.
   Date: 21 Apr 2019
   Modifications: ----
*/

using System;

class GFG
{

    static void printFun(int test)
    {
        // The printFun() function includes the
        // conditional if-else statements to have
        // it call itself.

        if (test < 1)
            return;

        // When int 'test' variable is NOT less than
        // 1, the program executes this else statement
        // in which it prints out the 'test' variable
        // in the following manner.

        // If the variable is 2, the program first
        // prints '2 ' and the statements inside the
        // else block are pushed on the stack. Then,
        // printFun(1) is called so that a local 'test'
        // variable is set to 1 and again, the else
        // statements are pushed. The functions
        // keep calling the same method until the
        // local 'test' variable returns 0 in which
        // case the printFun(0) goes to the above if
        // statement and returns printFun(1), which
        // then executes the statements and returns
        // printFun(2). The output will show:
        // 2 1 1 2.
        else
        {
            Console.Write(test + " ");

            printFun(test - 1);

            Console.Write(test + " ");
            return;
        }
    }

    public static void Main(String[] args)
    {
        int test = 3;
        printFun(test);
    }
} 

/*
      Example output:
      3 2 1 1 2 3
      
*/
