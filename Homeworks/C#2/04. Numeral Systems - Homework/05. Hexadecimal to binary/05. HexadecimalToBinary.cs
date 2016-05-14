using System;

//•	Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToBinary
{
    static void Main()
    {
        string hexValue = Console.ReadLine();
        ulong decimalNumber = Convert.ToUInt64(hexValue, 16);
        ulong remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("{0}", result);
    }
}

