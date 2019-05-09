/*
   Source: https://www.geeksforgeeks.org/c-sharp-interface/
   Author: Mithun Kumar
   Summary: This simple program demonstrates the implementation
            of an interface and its members.
   Date: 23 Apr 2019
   Modifications: ----
 */

using System;

interface Vehicle
{

    /* The Vehicle interface is calling the
       methods changeGear(), speedUp(),
       and applyBrakes() without the actual
       fields (abstract) as shown by generic,
       variable 'a' that's an int data type.     
    */
    void changeGear(int a);
    void speedUp(int a);
    void applyBrakes(int a);
}

 /* With the Vehicle interface declared, the
    Bicycle class implements the interface,
    setting the variables speed and gear as
    int data types.
 */
class Bicycle : Vehicle
{

    int speed;
    int gear;

    /* The changeGear method accepts the 'newGear'
       variable as an int type and sets gear
       to equal newGear variable.
    */
    public void changeGear(int newGear)
    {

        gear = newGear;
    }

    /* The speedUp method accpets 'increment'
       variable as an int type and sets the
       speed to equal speed + 'increment'
       variable.
     */
    public void speedUp(int increment)
    {

        speed = speed + increment;
    }

    /* The applyBrakes method has the same
       parameters as the two methods above
       but its speed returns 'decrement'
       value subtracted from speed.
     */
    public void applyBrakes(int decrement)
    {

        speed = speed - decrement;
    }

    public void printStates()
    {
        /* The console will write out the results
           after calculations are executed. The
           speed will initially return the value
           of speedUp. However, when applyBrakes
           method is executed, the old speed
           will subtract whatever the 'decrement'
           value will be for the applyBrakes method.

           If the program ran variableX.speedUp(10),
           the speedUp method will return 10 for the
           speed since speed was simply declared 'int
           speed.'

           If the same code ran variableY.applyBrakes(7),
           the console will return 3 for the speed
           because the new calculated speed is 10 - 7.

        */

        Console.WriteLine("speed: " + speed +
                          " gear: " + gear);
    }
}

    /* Another class called Bike implements 
       the Vehicle interface and declares its
       own speed and gear. The generic
       methods and their implementations are
       identical to that of the Bicycle class.
       However, because the Bike class is
       separate from the Bicycle class, the
       two will return different results as
       long as the input values are different.
    */
class Bike : Vehicle
{

    int speed;
    int gear;

    public void changeGear(int newGear)
    {

        gear = newGear;
    }


    public void speedUp(int increment)
    {

        speed = speed + increment;
    }

    public void applyBrakes(int decrement)
    {

        speed = speed - decrement;
    }

    public void printStates()
    {
        Console.WriteLine("speed: " + speed +
                          " gear: " + gear);
    }

}

class GFG
{

    public static void Main(String[] args)
    {

        /* The Bicycle class is used to create
           a new instance with the 'bicycle'
           variable. Since the Bicycle class
           is using abstract methods within
           the Vehicle interface, specific values
           for each method can be applied
           without conflicting with the Bike class.

           Each abstract method can now apply
           the int values and carry out their
           respective operations.
        */

        Bicycle bicycle = new Bicycle();
        bicycle.changeGear(2);
        bicycle.speedUp(3);
        bicycle.applyBrakes(1);

        Console.WriteLine("Bicycle present state :");
        bicycle.printStates();

        /* As with the Bicycle class, the Bike class
           creates a new instance for the abstract
           methods to evaluate the int values.
        */ 

        Bike bike = new Bike();
        bike.changeGear(1);
        bike.speedUp(4);
        bike.applyBrakes(3);

        Console.WriteLine("Bike present state :");
        bike.printStates();
    }
}

/*
        Example output:
        Bicycle present state :
        speed: 2 gear: 2
        Bike present state :
        speed: 1 gear: 1

*/