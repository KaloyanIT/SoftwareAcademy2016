using System;
using System.Numerics;

//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].

class NFactorial
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        NFactorialSum(number);
    }

    static void NFactorialSum(BigInteger number)
    {
        BigInteger sum = 1;
        for (BigInteger i = 1; i <= number; i++)
        {
            sum *= i;
        }
        Console.WriteLine(sum);
    }
}


