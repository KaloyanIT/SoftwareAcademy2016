using System;

//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

class FloatOrDouble
{
    static void Main(string[] args)
    {
        float firstNum = 12.345f;
        float secondNum = 3456.091f;
        double thirdNum = 34.567839023;
        double fourthNum = 8923.1234857;
        Console.WriteLine("{0} and {1} are in float.{2} and {3} are in double", firstNum, secondNum, thirdNum, fourthNum);
    }
}

