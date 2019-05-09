/*
   Source: https://www.sanfoundry.com/csharp-program-reverse-palindrome/
   Author: Manish Bhojasia
   Summary: This program determines if an entered number is a palindrome.
   Date: 5 May 2019
   Modifications: ----

 */

using System;
class program
{
    public static void Main()
    {

        int num, temp, remainder, reverse = 0;
        Console.WriteLine("Enter an integer \n");
        num = int.Parse(Console.ReadLine());

        // The temp variable will initially share the same
        // value as num. The num value will change as it's
        // used for calculations below.
        temp = num;

        // The while loop will execute as long as the 'num'
        // variable is greater than 0 as it's executing the
        // functions below.
        while (num > 0)
        {
            // The remainder variable will return the remainder
            // of an input value divided by 10. Then the
            // program will determine the value of reverse
            // variable by multiplying it to 10 and adding
            // the value of remainder. The original reverse
            // value used inside the reverse variable will
            // be 0. The num value is then assigned to the
            // value returned when it's divided by 10, i.e.,
            // 'num /= 10' means 'num = num/10'.
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num /= 10;
        }

        // The Console will print the temp value which was
        // the value of the original input while the reverse
        // value will print the value returned from calculations
        // executed during the while loop.
        Console.WriteLine("Given number is = {0}", temp);
        Console.WriteLine("Its reverse is  = {0}", reverse);

        // The condition statement checks to see if the temp
        // and reverse variables are equal and returns true.
        // If they are, the program prints out that it's a
        // palindrome.
        if (temp == reverse)
            Console.WriteLine("Number is a palindrome \n");
        else
            Console.WriteLine("Number is not a palindrome \n");
        Console.ReadLine();
    }
}

/*      
        Example output:
        Enter an integer
        252
        Given number is = 252
        Its reverse is  = 252
        Number is a palindrome

*/
