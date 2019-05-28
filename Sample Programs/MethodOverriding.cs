/*
   Source: https://www.geeksforgeeks.org/c-sharp-method-overriding/
   Author: SoM15242
   Summary: This program demonstrates Method overriding using
            virtual and override modifiers for base and
            derived class.
   Date: 22 Apr 2019
   Modifications: ----

 */
using System;

class baseClass
{

    // The virtual keyword is used to modify the
    // show() method which is from the BASE class.
    public virtual void show()
    {
        Console.WriteLine("Base class");
    }
}

class derived : baseClass
{

    // The override keyword here is used since it is
    // a derived class needing a modified method of
    // show().
    public override void show()
    {
        Console.WriteLine("Derived class");
    }
}

class GFG
{

    public static void Main()
    {

        // The obj variable is set as the
        // new baseClass(). As a result
        // obj.show() will invoke the method
        // from baseClass which is printing
        // "Base class."
        baseClass obj;
        obj = new baseClass();
        obj.show();

        // The same obj variable is now
        // declared as the new derived()
        // class. As a result, even though
        // it is a child class and inherits
        // the base class' method, the override
        // modifier was used to override
        // the baseClass method. As a result,
        // obj.show() will only print the derived
        // class' "Derived class."
        obj = new derived();
        obj.show();

        // If the derived class did not use override
        // modifier, obj.show() would invoke the
        // base method and its derived method.
        // The final output would have instead
        // displayed:
        // Base class
        // Base class
    }
}

/*
        Example output:
        Base class
        Derived class

*/

