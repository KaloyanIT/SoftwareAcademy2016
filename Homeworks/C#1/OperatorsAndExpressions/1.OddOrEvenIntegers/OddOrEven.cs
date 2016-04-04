using System;

//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

class OddOrEven
{
    static void Main(string[] args)
    {        
        string inputNum = Console.ReadLine();
        int checkNum = int.Parse(inputNum);
        if (checkNum % 2 == 0)
        {
            Console.WriteLine("even {0}", checkNum);
        }
        else
        {
            Console.WriteLine("odd {0}", checkNum);
        }
    }
}

