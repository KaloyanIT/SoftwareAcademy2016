using System;

//•	Write a program that shows the binary representation of given 16-bit signed 
//  integer number (the C# type short).

class BinaryShort
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2);
        Console.WriteLine(binary);
    }
}
//1111111111110101
//0000000000001011