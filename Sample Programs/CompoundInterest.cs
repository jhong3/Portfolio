/*
   Source: https://www.sanfoundry.com/csharp-program-compund-interest/
   Author: Manish Bhojasia
   Summary: This sample program collects keys and
            values pairs of data and checks to see
            if the given string is in the Dictionary
            using ContainsKey function.
   Date: 20 Apr 2019
   Modifications: Deleted redundancy for Total = 0.

*/

using System;
namespace compund
{
    class compound
    {
        static void Main(string[] args)
        {
            // The variables Total, interestRate, years,
            // annualCompound, and Amount are assigned to
            // double data type. The original program assigned
            // the value 0 to Total but since the variable
            // is assigned to actual calculation below, the
            // redundancy was removed.
            double Total, interestRate, years, annualCompound, Amount;

            // The variables Amount, interestRate, years and
            // annualCompound require user input. And because
            // input values are read as strings, they are
            // converted to double type use Convert.ToDouble.
            Console.Write("Enter the Initial Amount : ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of Interest : ");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Enter the Number of Years : ");
            years = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of Times the Interest will be Compounded : ");
            annualCompound = Convert.ToDouble(Console.ReadLine());

            // The for loop is used to continuously calculate and print
            // the total per year until t is less than the input variable
            // 'years'.
            for (int t = 1; t < years + 1; t++)
            {
                Total = Amount * Math.Pow((1 + interestRate / annualCompound),
                                         (annualCompound * t));
                Console.Write("Your Total for Year {0} "
                            + "is {1:F0}. \n", t, Total);

            }

            Console.ReadLine();
        }
    }
}