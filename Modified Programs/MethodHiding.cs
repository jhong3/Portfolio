/*
   Source: https://www.sanfoundry.com/csharp-program-method-hiding/
   Author: Manish Bhojasia
   Summary: This program demonstrates method hiding.
   Date: 13 Apr 2019
   Modifications: Added a derived class of a child class A
                  to show that the derived classes retain
                  the base class' functionality.

 */

using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1
{
    public class Demo
    {

        public virtual double Area(double r)
        {
            return r * r;
        }
        public void func()
        {
            Console.WriteLine("Parent Class");
        }
    }
    public class A : Demo
    {

        public override double Area(double r)
        {

            return base.Area(r) * r;
        }
        public new void func()
        {
            Console.WriteLine("Child Class");
        }
    }

    // The derived class of a derived class
    // retains all of the parents' methods and
    // employs its own functions.
    public class B : A
    {

        public override double Area(double r)
        {
            return base.Area(r) * r + 2;
        }

        public new void func()
        {
            Console.WriteLine("Grandchild");
        }
    }
    public class Test
    {

        // Variables o0 and o2 were added to
        // show in the output console that the
        // 'newest' class still inherits the
        // properties from the base class while
        // utilizing its own method.
        public static void Main(string[] args)
        {
            Demo o0 = new Demo();
            Console.WriteLine(o0.Area(30));
            o0.func();
            A o1 = new A();
            Console.WriteLine(o1.Area(20));
            o1.func();
            B o2 = new B();
            Console.WriteLine(o2.Area(25));
            o2.func();
            Console.ReadLine();
        }
    }
}

/*
            Example Output:
            900
            Parent Class
            8000
            Child Class
            390627
            Grandchild

*/
