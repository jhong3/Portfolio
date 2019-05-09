/*
   Source: https://www.sanfoundry.com/csharp-program-average-height/
   Author: Manish Bhojasia
   Summary: This program determines which category of height group
            the user's input belongs to when executed using if, else-if
            and else statements.
   Date: 21 Apr 2019
   Modifications: ----

 */


using System;
class program
{
    public static void Main()
    {
        // The variable 'height' is assigned to float type
        // since the numeric values will be calculated up to
        // tenths place in decimal. Double, though more precise,
        // is not used since it is slower. Int is not used
        // because it will return whole numbers.
        float height;
        Console.WriteLine("Enter  the Height (in centimeters) \n");
        height = int.Parse(Console.ReadLine());

        // The following if, else-if, and else statements are
        // used to determine if the input value meets specific
        // condition. When it does, the program displays
        // Dwarf, Average Height, Taller, or Abnormal Height.
        if (height < 150.0)
            Console.WriteLine("Dwarf \n");
        else if ((height >= 150.0) && (height <= 165.0))
            Console.WriteLine(" Average Height \n");
        else if ((height >= 165.0) && (height <= 195.0))
            Console.WriteLine("Taller \n");
        else
            Console.WriteLine("Abnormal height \n");
    }
}
/*
        Enter the Height(in centimeters)
        165
        Average Height

*/