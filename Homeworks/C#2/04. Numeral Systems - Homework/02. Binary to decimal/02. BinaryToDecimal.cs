using System;

//•	Write a program to convert binary numbers to their decimal representation

class BinaryToDecimal
{
    static void Main()
    {
        string number = Console.ReadLine();
        int numberBase = 2;
        int toBase = 10;
        string converted = Convert.ToString(Convert.ToInt32(number, numberBase), toBase);
        Console.WriteLine(converted);
    }
}

