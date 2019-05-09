/*
   Source: https://www.geeksforgeeks.org/nested-classes-in-c-sharp/
   Author: ankita_saini
   Summary: This simple program demonstrates the concept of
            nested class.
   Date: 5 May 2019
   Modifications: ----

 */

using System;


public class Outer_class
{
    // 'method1' is declared as a public method
    // that returns void, or does not expect a
    // return value. It will be the method of
    // the 'Outer_class'.
    public void method1()
    {
        Console.WriteLine("Outer class method");
    }

    public class Inner_class
    {

        // The Inner_class is nested inside the
        // Outer_class class and has its own
        // method that prints "Inner class Method."
        public void method2()
        {
            Console.WriteLine("Inner class Method");
        }
    }
}
public class GFG
{

    static public void Main()
    {

        // A new instance of the outer class is created using
        // the variable 'obj1'. The program then invokes the
        // method1() method with the new variable.
        Outer_class obj1 = new Outer_class();
        obj1.method1();

        // obj1.method2() will return an exception because
        // the outer class cannot access the inner class
        // method.

        // An instance of the inner class is made using the
        // 'obj2' variable. The syntax requires
        // Outer_class.Inner_class because the inner class
        // is nested inside the outer class. Simply using
        // Inner_class obj2 to create will return an
        // exception for missing reference.
        Outer_class.Inner_class obj2 =
                    new Outer_class.Inner_class();

        // The new variable now invokes the inner class method.
        obj2.method2();
    }
}

/*      
        Example output:
        Outer class method
        Inner class Method

*/
