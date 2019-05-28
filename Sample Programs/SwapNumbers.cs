/*
   Source: https://www.sanfoundry.com/csharp-programs-generate-swap/
   Author: Manish Bhojasia
   Summary: This simple program swaps two numbers.
   Date: 5 May 2019
   Modifications: 

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 'num1', 'num2', and 'temp' are
            // declared int data types as they will be used
            // to store int values.
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");

            // The int.Parse() method will convert the input
            // strings for 'num1' and 'num2' to integer values.
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            // To 'move' the integers, the value for num1
            // is assigned to the temp variable, num2 value
            // assigned to num1 variable, and finally temp
            // value is assigned to num2 variable.
            
            // If input for num1 is 3 and num2 is 5, the
            // 3 is stored into the temp, 5 is assigned
            // to the num1, and 3 is assigned to num2. num1
            // returns 5 and num2 returns 3.
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");

            // With the newly assigned values, the input
            // values are swapped.
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}

/*      
        Example output:
        Enter the First Number : 23

        Enter the Second Number : 25
        
        After Swapping :
        First Number : 25
        Second Number : 23

*/
