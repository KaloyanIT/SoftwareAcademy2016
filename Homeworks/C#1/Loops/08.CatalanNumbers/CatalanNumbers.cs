using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger n2Factorial = 1;
        BigInteger nPlusFactorial = 1;
        int i = 1;
        while (i <= (2*n))
        {
            if (i <= n)
            {
                nFactorial *= i;
            }
            if (i <= (n + 1))
            {
                nPlusFactorial *= i;
            }
            n2Factorial *= i;
            i++;
        }
        BigInteger result = n2Factorial/(nPlusFactorial*nFactorial);
        Console.WriteLine(result);
    }
}
