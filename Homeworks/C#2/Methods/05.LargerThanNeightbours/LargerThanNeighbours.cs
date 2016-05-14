using System;
using System.Linq;

//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

class LargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        string textNumbers = Console.ReadLine();
        var numbers = textNumbers.Split(' ').ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }
        Console.WriteLine(FindLargerElement(array));
    }

    static int FindLargerElement(int[] array)
    {
        int count = 0;
        for (int position = 1; position < array.Length - 1; position++)
        {
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                count++;
            }
        }
        return count;
    }


}

