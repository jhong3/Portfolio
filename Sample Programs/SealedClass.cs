/*
   Source: https://www.geeksforgeeks.org/c-sharp-sealed-class/
   Author: Akanksha_Rai
   Summary: This program demonstrates a sealed method in a
            derived class.
   Date: 5 May 2019
   Modifications: ----

 */

using System;

class Printer
{

    // The Printer class implements two methods, show()
    // and print(). The "virtual" modifier allows for
    // derived classes to implement the same methods and
    // change the values.
    public virtual void show()
    {
        Console.WriteLine("display dimension : 6*6");
    }

    // Display Function 
    public virtual void print()
    {
        Console.WriteLine("printer printing....\n");
    }
}

// The LaserJet is a derived class from the base
// Printer class.
class LaserJet : Printer
{

    // The modifiers "sealed" and "override" in the
    // show() method allows the LasertJet class to not
    // only change the string values from the base
    // class show() method, but restricts other classes
    // from inheriting it.
    sealed override public void show()
    {
        Console.WriteLine("display dimension : 12*12");
    }

    // The "override" method allows the LasertJet class
    // to change the string values of the print() method.
    override public void print()
    {
        Console.WriteLine("Laserjet printer printing....\n");
    }
}

// Officejet class is a derived class of
// LaserJet.
class Officejet : LaserJet
{

    // The Officejet class cannot use the "override"
    // modifier because its parent class, LaserJet,
    // sealed the show() method. As a result, it
    // will print the same string values from its
    // parent class show() method.

    // The print() method, however, can still change
    // its string values since LaserJet did not use
    // "sealed" modifier.
    override public void print()
    {
        Console.WriteLine("Officejet printer printing....");
    }
}

class Program
{


    static void Main(string[] args)
    {
        // A new instance of the Printer class is created
        // with the variable 'p'. The methods invoked
        // will display the strings from the base class
        // methods.
        Printer p = new Printer();
        p.show();
        p.print();

        // A new instance of the LaserJet class is created
        // with the local variable 'ls'. It will implement
        // the derived class' methods and their modified
        // strings.
        Printer ls = new LaserJet();
        ls.show();
        ls.print();

        // A new instance of the Officejet class is created
        // with the variable 'of'. It will invoke the show()
        // method from the LaserJet class but implement the
        // altered string of Officejet class for the print()
        // method.
        Printer of = new Officejet();
        of.show();
        of.print();
    }
}

/*      
        Example output:
        display dimension : 6*6
        Printer printing....

        display dimension : 12*12
        LaserJet printer printing....

        display dimension : 12*12
        Officejet printer printing....

*/
