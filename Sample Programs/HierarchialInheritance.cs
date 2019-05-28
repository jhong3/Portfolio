/*
   Source: https://www.sanfoundry.com/csharp-program-hierarchical-inheritence/
   Author: Manish Bhojasia
   Summary: This program demonstrates hierarchial inheritance.
   Date: 21 Apr 2019
   Modifications: ----

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Principal class will ouput
            // 'Monitor' since the variable
            // 'g' is the simply declared as a
            // new Princpal() class.
            Principal g = new Principal();
            g.Monitor();

            // d will return 'Monitor' as it
            // is a child class of the Principal
            // so it will inherit the base
            // function. At the same time, it
            // can call its own function when
            // used in d.Teach().
            Teacher d = new Teacher();
            d.Monitor();
            d.Teach();

            // The student class is another
            // child class of Principal. It
            // contains its own unique function
            // printing out 'Learn' while
            // retaining Principal's 'Monitor'
            // and thus will be able to call it
            // when used in dot notation.
            Student s = new Student();
            s.Monitor();
            s.Learn();
            Console.ReadKey();
        }
        class Principal
        {
            public void Monitor()
            {
                Console.WriteLine("Monitor");
            }
        }
        class Teacher : Principal
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        class Student : Principal
        {
            public void Learn()
            {
                Console.WriteLine("Learn");
            }
        }
    }
}
/*
        Example output:
        Monitor
        Monitor
        Teach
        Monitor
        Learn

 */