using System;

//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided(without remainder) by 7 and 5 at the same time.

class DivideBy7And5
{
    static void Main(string[] args)
    {
        Console.Write("Input number:");
        int checkNum = int.Parse(Console.ReadLine());
        if (checkNum % 35 == 0)
        {
            Console.WriteLine("The number can be divided by 5 and 7");
        }
        else
        {
            Console.WriteLine("The number can't be divided by 5 and 7");
        }
    }
}

