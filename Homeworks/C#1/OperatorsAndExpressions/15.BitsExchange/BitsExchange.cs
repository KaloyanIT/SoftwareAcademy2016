using System;

//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class BitsExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        //int bit3 = (num >> 3) & 1;
        //int bit24 = (num >> 24) & 1;
        //num = num & (~(1 << 24)) | (bit3 << 24);
        //num = num & (~(1 << 24)) | (bit24 << 3);
        //Console.WriteLine(num

        for (int i = 3, j = 24; i < 6; i++, j++)
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                number = ChangeBits(number, i, j);
            }
        }

        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);

        
    }

    private static uint ChangeBits(uint number, int firstposition, int secondPosition)
    {
        number ^= (1u << firstposition);
        return number ^ (1u << secondPosition);
    }
}


