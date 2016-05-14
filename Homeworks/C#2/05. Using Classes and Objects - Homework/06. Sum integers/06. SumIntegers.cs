using System;
using System.Linq;

//•	You are given a sequence of positive integer values written into a string, separated by spaces.
//•	Write a function that reads these values from given string and calculates their sum.

class SumIntegers
{
    static void Main()
    {
        string separatedNumbers = Console.ReadLine();
        var arrayOfNumbers = separatedNumbers.Split(' ').ToArray();
        int sum = 0;
        int[] array = new int[arrayOfNumbers.Length];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            array[i] = int.Parse(arrayOfNumbers[i]);
            sum += array[i];
        }       
        Console.WriteLine("{0}", sum);
    }
}

