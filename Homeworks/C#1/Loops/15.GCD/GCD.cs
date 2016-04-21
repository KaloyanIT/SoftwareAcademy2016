using System;

class GCD
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var numbers = input.Split(' ');
        int A = int.Parse(numbers[0]);
        int B = int.Parse(numbers[1]);
        int currentA = A;
        int currentB = B;
        int reminder = 1;
        while (currentB > 0)
        {
            reminder = currentA % currentB;            
            currentA = currentB;
            currentB = reminder;
        }
        Console.WriteLine(currentA);
    }
}

