using System;

class HexToDecimal
{
    static void Main(string[] args)
    {
        string hexValue = Console.ReadLine();
        ulong decValue = Convert.ToUInt64(hexValue, 16);
        Console.WriteLine(decValue);
    }
}

