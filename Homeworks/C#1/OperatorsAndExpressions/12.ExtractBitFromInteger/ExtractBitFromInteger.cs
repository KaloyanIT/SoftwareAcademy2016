using System;

//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger
{  
    static void Main(string[] args)
    {
        Console.Write("Enter number:");
        int inputNum = int.Parse(Console.ReadLine());
        Console.Write("Enter position:");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int result = inputNum & mask;
        if (result == 0)
        {
            Console.WriteLine("The {0} bit is 0", position);
        }
        else
        {
            Console.WriteLine("The {0} bit is 1", position);
        }
    }
}

