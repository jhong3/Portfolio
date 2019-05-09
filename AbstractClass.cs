/*
   Source: https://www.geeksforgeeks.org/c-sharp-abstract-classes/
   Author: SoM15242
   Summary: This program calculates the area of a square using
            abstract classes and methods.
   Date: 5 May 2019
   Modifications: ----

 */

using System;

abstract class AreaClass
{
    // The AreaClass class and Area() method are declared
    // abstract. The method is instructed to accept int
    // data types without being given a specific function.
    abstract public int Area();
}

class Square : AreaClass
{
    // The derived class, Square, inherits the same
    // method from its base AreaClass. The side
    // variable is declared int data type and assigned
    // to the value 0.
    int side = 0;

    // A constructor class Square is created to accept
    // int data types for the variable 'n' which is
    // assigned to the side variable.
    public Square(int n)
    {
        side = n;
    }

    // The "override" modifier allows the Square class
    // to redefine the inherited Area() method to contain
    // abstract side * side calculation. The calculation
    // only holds variables and lack specific values,
    // keeping the method abstract.
    public override int Area()
    {
        return side * side;
    }
}

class gfg
{
    public static void Main()
    {
        // A new instance of the Square class with the
        // argument 6 is created using the variable 's'.
        // The Console.WriteLine() concatenates the
        // string with the result returned from the derived
        // Area() method. The 6 will be used to equal 'n',
        // which is assigned to the side variable. Then, the
        // derived Area() method will substitute side variable
        // with integer 6 and multiply by itself to return 36.
        Square s = new Square(6);
        Console.WriteLine("Area  = " + s.Area());
    }
}

/*      
        Example output:
        Area  = 36
*/
