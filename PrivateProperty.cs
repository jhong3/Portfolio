/*
   Source: https://www.dotnetperls.com/property
   Author: Sam Allen
   Summary: This program illustrates the use of a private property.
   Date: 5 May 2019
   Modifications: ----

 */

using System;

class Example
{
    // The '_id' variable is declared as an int data type for
    // later use.
    int _id;

    // The private property of Id will pass int data types. 
    // The get statement returns the value of _id while
    // the set statement assigns an int data ('value').
    
    private int Id
    {
        get
        {
            return this._id;
        }
        set
        {
            this._id = value;
        }
    }
    public void Display()
    {
        // The private property's value is accessed within
        // the method. However, only the property in the
        // same enclosed class can be used.
        this.Id = 7;
        Console.WriteLine(this.Id);
    }
}

class Program
{
    static void Main()
    {
        // A new instance of the Example class is created
        // using the 'example' variable. The variable then
        // invokes the Display() method of the Example class
        // in the Main() method. Because the property is
        // set to private, Main() cannot set a new value for
        // the variable Id.
        Example example = new Example();
        example.Display();
    }
}
/*      
        Example output:
        7

*/
