using System;

//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it.Try to compile the code.

class DeclareVariable
{
    static void Main(string[] args)
    {
        ushort firstNumber = 52130;
        sbyte secondNum = -112;
        int thirdNum = 4825932;
        byte fourthNum = 97;
        short fifthNum = -10000;
        Console.WriteLine("{0},{1},{2},{3},{4}", firstNumber, secondNum, thirdNum, fourthNum, fifthNum);
    }
}

