using System;

//•	Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalToHexadecimal
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string converted = Convert.ToString(number, 16);
        Console.WriteLine(converted);
    }
}

