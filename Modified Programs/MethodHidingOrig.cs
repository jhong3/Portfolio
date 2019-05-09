/*
   Source: https://www.sanfoundry.com/csharp-program-method-hiding/
   Author: Manish Bhojasia
   Summary: This program demonstrates method hiding.
   Date: 13 Apr 2019
   Modifications: ----

 */

using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1
{
    public class Demo
    {
        // The base class Demo is made with the
        // property Area that returns r * r.
        public virtual double Area(double r)
        {
            return r * r;
        }
        public void func()
        {
            Console.WriteLine("Base Class");
        }
    }
    public class A : Demo
    {

        // A is a child (derived) class with the parent
        // class Demo. It retains the same properties
        // and also has its own unique Area function.
        // Whatever the 'r' value is, the function from
        // the derived class will use both the base Area
        // function and its own Area function, i.e., if
        // r = 10, the program will calculate the base Area
        // 10 * 10 to retrieve base.Area and then A:Demo
        // will run its Area function again to get 1000.
        public override double Area(double r)
        {

            return base.Area(r) * r;
        }
        public new void func()
        {
            Console.WriteLine("Derived Class");
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            // The object 'o1' variable is created for
            // the child class A. o1 will then calculate
            // the Area using the derived class and print
            // the result. Afterwards, o1.func(); is
            // executed which will print the child class'
            // "Derived Class" line.
            A o1 = new A();
            Console.WriteLine(o1.Area(20));
            o1.func();
            Console.ReadLine();
        }
    }
}

/*
            Example Output:
            8000
            Derived Class

*/