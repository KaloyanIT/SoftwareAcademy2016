using System;
using System.Linq;

//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class GetLargestNumber
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        var arrayNum = numbers.Split(' ').ToArray();
        int firstNumber = int.Parse(arrayNum[0]);
        int secondNumber = int.Parse(arrayNum[1]);
        int thirdNumber = int.Parse(arrayNum[2]);
        int maximal = GetMax(firstNumber, secondNumber);
        Console.WriteLine(GetMax(maximal, thirdNumber));
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;
        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }
        return max;

    }
}

