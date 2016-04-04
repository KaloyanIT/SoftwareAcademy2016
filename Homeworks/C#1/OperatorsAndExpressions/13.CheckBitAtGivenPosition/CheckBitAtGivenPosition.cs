using System;

//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p(counting from 0, starting from the right) in given integer number n, has value of 1.

class CheckBitAtGivenPosition
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        
       
        if ((number & ((long)1 << p)) != 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

