using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = number; i >= 2; i--)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
                break;
            }
        }

    }

    static bool IsPrime(int num)
    {
        bool isPrime = true;
        if (num % 2 == 0) return false;
        for (int i = 3; i <= Convert.ToInt32(Math.Sqrt(num)); i = i + 2)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}

