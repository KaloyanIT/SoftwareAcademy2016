using System;

//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        Console.WriteLine(nullInt);
        double? nullDouble = null;
        Console.WriteLine(nullDouble);
        nullInt = 5;
        Console.WriteLine(nullInt.GetValueOrDefault());
        nullDouble = 10;
        Console.WriteLine(nullDouble.GetValueOrDefault());
    }
}

