using System;

internal class ThreeNumbers
{
    private static void Main()
    {
        var firstNum = double.Parse(Console.ReadLine());
        var secondNum = double.Parse(Console.ReadLine());
        var thirdNum = double.Parse(Console.ReadLine());


        //PrintBiggest(firstNum, secondNum, thirdNum);
        Console.WriteLine(Math.Max(Math.Max(firstNum, secondNum), thirdNum));
        Console.WriteLine(Math.Min(Math.Min(firstNum, secondNum), thirdNum));
        //PrintSmallest(firstNum, secondNum, thirdNum);


        var mean = (firstNum + secondNum + thirdNum)/3;

        Console.WriteLine("{0:F2}", mean);
    }
}