using System;

//•	You are given a sequence of positive integer values written into a string, separated by spaces.
//•	Write a function that reads these values from given string and calculates their sum.

class SumIntegers
{
    static void Main()
    {
        string separatedNumbers = "5 5 5 5 5 5 5 5 5 5";
        var arrayOfNumbers = separatedNumbers.Split(' ');
        int sum = 0;
        int[] array = new int[arrayOfNumbers.Length];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            array[i] = int.Parse(arrayOfNumbers[i]);
        }
        for (int a = 0; a < array.Length; a++)
        {
            sum += array[a];
        }
        Console.WriteLine("Sum is: {0}", sum);
    }
}

