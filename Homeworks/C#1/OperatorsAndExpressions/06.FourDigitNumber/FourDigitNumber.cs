using System;
using System.Linq;

//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string numberToString = number.ToString();
        int numberLength = numberToString.Length;
        int sum = 0;

        for (int i = 0; i < numberToString.Length; i++)
        {
            sum += (number%10);
            number /= 10;
        }

        Console.WriteLine(sum);
        Console.WriteLine(numberToString[3] + "" + numberToString[2] + "" + numberToString[1] + "" + numberToString[0]);
        Console.WriteLine(numberToString[3] + "" + numberToString[0] + "" + numberToString[1] + "" + numberToString[2]);
        Console.WriteLine(numberToString[0] + "" + numberToString[2] + "" + numberToString[1] + "" + numberToString[3]);
    }
}