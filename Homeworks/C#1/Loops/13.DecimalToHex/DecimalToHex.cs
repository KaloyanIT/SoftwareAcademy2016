using System;

class DecimalToHex
{
    static void Main(string[] args)
    {
        ulong decValue = ulong.Parse(Console.ReadLine());
        string hexValue = decValue.ToString("X");
        Console.WriteLine(hexValue);
    }
}

