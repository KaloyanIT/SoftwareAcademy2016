using System;
using System.Numerics;

class CalculateAgain
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int i = 1;
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger result = 1;
        if (n >= k)
        {
            while ( i <= n)
            {
                if (k >= i)
                {
                    kFact *= i;
                }
                nFact *= i;
                i++;
            }
        }
        else
        {
            while (i <= k)
            {
                if (n >= i)
                {
                    nFact *= i;
                }
                kFact *= i;                
                i++;
            }
        }
        Console.WriteLine(nFact / kFact);
    }
}

