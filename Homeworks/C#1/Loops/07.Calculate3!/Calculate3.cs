using System;
using System.Numerics;


class Calculate3
{ 
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int i = 1;
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nkFactorial = 1;
        while (i <= n)
        {
            if (k >= i)
            {
                kFactorial *= i;
            }
            if ((n - k) >= i)
            {
                nkFactorial *= i;
            }
            nFactorial *= i;
            i++;
        }
        BigInteger result = nFactorial / (kFactorial*nkFactorial);
        Console.WriteLine(result);

    }
}

