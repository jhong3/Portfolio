/*
   Source: https://www.codeproject.com/Articles/602141/Polymorphism-in-NET
           https://www.c-sharpcorner.com/UploadFile/8911c4/different-between-method-overriding-method-hiding-new-keyw/
   Author: Manish Agrahari, Mahesh Alle
   Summary: This program demonstrates method hiding in polymorphism.
   Date: 5 May 2019
   Modifications: ----

 */

using System;

namespace PolymorphismByManishAgrahari
{
    class Program
    {
        public class Base
        {
            // The public "Base" class implements the Show()
            // method which, when invoked, prints "Show From
            // Base Class."
            public virtual void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }

        public class Derived : Base
        {
            // The derived class, Derived, implements its own
            // Show() method with the string "Show From Derived
            // Class."
            public new void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        static void Main(string[] args)
        {
            // A new instance of Derived class is created using the
            // Base class variable 'objBaseRefToDerived'. When the
            // variable calls the Show() method, it will not print
            // the string from the Derived class. Instead, the program
            // will print the Base class' strings because Derived.Show()
            // is hidden because of the "new" keyword in its method.
            // In order for the object to reference the derived class
            // method, the modifier "override" must be used in the
            // derived class' Show() method.
            Base objBaseRefToDerived = new Derived();
            objBaseRefToDerived.Show();

            Console.ReadLine();

            // The difference between Method Overriding and Method
            // Hiding is that the former implements a method that is
            // based on the run-time type argument "this" while the
            // latter's implementation of a method is based on
            // compile-time "this". Additionally, "override" is
            // object-type specific while "new" is reference-type
            // specific.
        }
    }
}

/*      
        Example output:
        Show From Base Class.

*/
