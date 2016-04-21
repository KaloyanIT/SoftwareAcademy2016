using System;
using System.Diagnostics.Contracts;
using System.Linq;

internal class BiggestOf3
{
    private static void Main(string[] args)
    {
        var firstInteger = double.Parse(Console.ReadLine());
        var secondInteger = double.Parse(Console.ReadLine());
        var thirdInteger = double.Parse(Console.ReadLine());
        double[] numbers = new[] {firstInteger, secondInteger, thirdInteger};
        Array.Sort(numbers);
        Console.WriteLine(numbers[2]);
    }
}