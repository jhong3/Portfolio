/*
   Source: https://www.codeproject.com/Articles/602141/Polymorphism-in-NET
   Author: Manish Agrahari
   Summary: This program demonstrates a derived class to alter the
            implementation of the base class method through method
            overriding.
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
            // The base class implements the Show() method which
            // will print "Show From Base Class."
            public virtual void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }

        public class Derived : Base
        {
            // The derived class also implements the Show() method
            // but contains a different string. The 'override'
            // keyword allows it to use the same method with a
            // different string value.
            public override void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        static void Main(string[] args)
        {
            // A new instance of Derived class is created using
            // the base class 'objBaseRefToDerived' variable. The
            // objBaseRefToDerived invokes the Show() method but
            // will print "Show From Derived Class" instead of
            // "Show From Base Class" due to the override keyword
            // implemented by the Derived class.
            Base objBaseRefToDerived = new Derived();
            objBaseRefToDerived.Show();

            Console.ReadLine();
        }
    }
}
/*      
        Example output:
        Show From Derived Class.

*/
