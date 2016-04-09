using System;

//Problem 16.** Bit Exchange(Advanced)

//Write a program that exchanges bits { p, p+1, …, p+k-1}
//with bits { q, q+1, …, q+k-1}
//of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

internal class BItsExchangeAdvanced
{
    private static void Main()
    {
        var number = uint.Parse(Console.ReadLine());

        var p = int.Parse(Console.ReadLine());

        var q = int.Parse(Console.ReadLine());

        var k = int.Parse(Console.ReadLine());


        if (p > q)
        {
            var temp = q;
            q = p;
            p = temp;
        }

        if (InputIsCorrect(p, q, k))
        {
            var mask = ((number >> p) ^ (number >> q)) & ((1u << k) - 1);
            var result = number ^ ((mask << p) | (mask << q));
            Console.WriteLine(result);
        }
    }

    private static bool InputIsCorrect(int p, int q, int k)
    {
        if (p < 0 || p > 32 || q < 0 || q > 32)
        {
            Console.WriteLine("out of range");
            return false;
        }
        if (p + k >= q)
        {
            Console.WriteLine("overlapping");
            return false;
        }
        if (q + k > 32)
        {
            Console.WriteLine("out of range");
            return false;
        }
        return true;
    }
}

}