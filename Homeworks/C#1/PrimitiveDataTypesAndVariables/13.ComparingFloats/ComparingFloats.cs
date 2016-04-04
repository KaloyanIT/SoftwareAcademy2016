using System;

//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers(double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

class ComparingFloats
{
    static void Main()
    {
        string firstNumInput = Console.ReadLine();
        string secondNumInput = Console.ReadLine();
        float a = float.Parse(firstNumInput);
        float b = float.Parse(secondNumInput);
        bool equalAB = Math.Abs(a - b) < 1e-6;        
        if (equalAB == true)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

