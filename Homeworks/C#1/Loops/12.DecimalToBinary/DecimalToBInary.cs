using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        long remainder;
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

