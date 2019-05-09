/*
   Source: https://www.sanfoundry.com/csharp-program-multiple-exceptions/
   Author: Manish Bhojasia
   Summary: This program retrieves demonstrates various exceptions that occur
            when user input is invalid, by employing the try-catch and the switch
            statement.
   Date: 5 Apr 2019
   Modifications: ----

 */
using System;
class Exercise
{
    static void Main()
    {
        // Variables Num1 and Num2 are assigned to the double
        // data type. Result is also assigned to double value
        // type but also set to equal 0.00 to return string format
        // similar to the input value.
        double Num1, Num2;
        double Result = 0.00;
        char op;

        // The try method now tests and checks to see if the inputs
        // return a valid double and char values when the program
        // requests inputs.
        try
        {
            Console.Write("Enter your First Number :  ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter an Operator  (+, -, * or /): ");
            op = char.Parse(Console.ReadLine());
            if (op != '+' && op != '-' &&
                op != '*' && op != '/')
                throw new Exception(op.ToString());
            Console.Write("Enter your Second Number :");
            Num2 = double.Parse(Console.ReadLine());
            if (op == '/')
                if (Num2 == 0)
        // The if conditions check to see if the input attempts to
        // divide by zero and will throw the exception message to
        // the output console window if it does.
                    throw new DivideByZeroException("Division by zero is not allowed");
            Result = Calculator(Num1, Num2, op);
            Console.WriteLine("\n{0} {1} {2} = {3}", Num1, op, Num2, Result);
        }

        // The catch methods are executed when the inputs that are
        // thrown return exceptions, displaying respective error
        // messages.
        catch (FormatException)
        {
            Console.WriteLine("The number you typed is not valid");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Operation Error: {0} is not a valid op", ex.Message);
        }
        Console.Read();
    }

    static double Calculator(double v1, double v2, char op)
    {
        // The Result is assigned to 0.00 value
        // in order for the operations to be
        // performed since not all of the operations
        // will return a value.
        double Result = 0.00;

        switch (op)
        {
            case '+':
                Result = v1 + v2;
                break;
            case '-':
                Result = v1 - v2;
                break;
            case '*':
                Result = v1 * v2;
                break;
            case '/':
                Result = v1 / v2;
                break;
        }
        return Result;
    }
}

/*
                    Example Output:
                    Enter Your First Number : 10
                    Enter an Operator(+, -, * or /) : ,
                    Operation Error : , is not a Valid Operator

*/