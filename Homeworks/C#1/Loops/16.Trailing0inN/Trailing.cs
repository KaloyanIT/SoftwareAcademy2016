using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1; // I Use BigInteger Only for Comparison purpoise and not for solving the problem!!!
        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }

        //Console.WriteLine("{0}! = {1}", n, nFact);

        int zeroCounter = 0;

        while (true)
        {
            int result = n / 5;
            if (result != 0)
            {
                zeroCounter = zeroCounter + result;
                n = result;
            }
            else
            {
                Console.WriteLine(zeroCounter);
                break;
            }
        }
    }
}
