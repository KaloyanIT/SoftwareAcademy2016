using System;
using System.Diagnostics.Contracts;
using System.Linq;

internal class Sort3Numbers
{
    private static void Main(string[] args)
    {
        var firstInteger = int.Parse(Console.ReadLine());
        var secondInteger = int.Parse(Console.ReadLine());
        var thirdInteger = int.Parse(Console.ReadLine());
        int temp = 0;
        if (firstInteger < secondInteger)
        {
            temp = firstInteger;
            firstInteger = secondInteger;
            secondInteger = temp;
        }
        if (firstInteger < thirdInteger)
        {
            temp = firstInteger;
            firstInteger = thirdInteger;
            thirdInteger = temp;
        }
        if (thirdInteger > secondInteger)
        {
            temp = secondInteger;
            secondInteger = thirdInteger;
            thirdInteger = temp;
        }
        Console.WriteLine("{0} {1} {2}", firstInteger, secondInteger, thirdInteger);

    }
}
