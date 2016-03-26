using System;

//•	Write a program to convert decimal numbers to their binary representation

class DecimalToBinary
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string converted = Convert.ToString(number, 2);
        Console.WriteLine("Binary representation is: {0}", converted);
    }
}
