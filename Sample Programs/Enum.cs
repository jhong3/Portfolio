/*
   Source: https://www.tutorialspoint.com/csharp/csharp_enums.htm
   Author: Tutorials Point
   Student: John Hong
   Summary: This program demonstrates a simple use of enumeration
            within C#.
   Date: 30 Apr 2019
   Modifications: ----

*/

using System;

namespace EnumApplication
{
    class EnumProgram
    {
        // 'Days' is assigned to the enum data type.
        // Because enumeration contains a constant
        // set of values, the days of the week are used
        // for the elements within the enumeration.
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {

            // Here, WeekdayStart and WeekdayEnd variables
            // are assigned to int data types because
            // Days.Value return an int type. The Days.Value
            // is an int because the dot notation function
            // are calling the position of the elements (0-6).
            
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            // The Console.WriteLine will print the respective
            // parameter values in place of {0} string, i.e.,
            // WeekdayStart will return value 1 which will
            // replace the {0} in the string.
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();
        }
    }
}

/*
            Example output:
            Monday: 1
            Friday: 5

*/
