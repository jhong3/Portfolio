/*
   Source: https://www.geeksforgeeks.org/c-sharp-boxing-unboxing/
   Author: jit_t
   Summary: This simple program illustrates the concept of boxing
            and unboxing.
   Date: 22 Apr 2019
   Modifications: ----

 */


using System;
class GFG
{
       
    static public void Main()
    {

        // int value 23 is assigned to the num
        // variable.
        int num = 23;

        // Here, the obj variable is 'boxed' by
        // converting the value type into a
        // reference object type.
        object obj = num;

        // The previous boxed is now 'unboxed'
        // as it's converted back into an int
        // type under a new variable, i.
        int i = (int)obj;

        // The console will print the same int value
        // since they were boxed and unboxed value of
        // num.
        Console.WriteLine("Value of ob object is : " + obj);
        Console.WriteLine("Value of i is : " + i);
    }
}

/*
        Example output:
        Value of ob object is : 23
        Value of i is : 23

*/