using System;

//•	Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHexadecimal
{
    static void Main()
    {
        string number = Console.ReadLine();
        int numberBase = 2;
        int toBase = 16;
        string converted = Convert.ToString(Convert.ToInt32(number, numberBase), toBase);
        Console.WriteLine(converted);
    }
}

