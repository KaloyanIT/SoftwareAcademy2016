using System;

class BiggestOf5
{
    static void Main(string[] args)
    {
        var firstNumber = double.Parse(Console.ReadLine());
        var secondNumber = double.Parse(Console.ReadLine());
        var thirdNumber = double.Parse(Console.ReadLine());
        var fourthNumber = double.Parse(Console.ReadLine());
        var fifthNumber = double.Parse(Console.ReadLine());
        double[] numbers = new[] { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber};
        Array.Sort(numbers);
        Console.WriteLine(numbers[4]);
    }
}

