using System;

//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

class BinarySearch
{
    static void Main()
    {
        int[] array = { 7, 18, 3, 21, 8, 9, 16, 31, 6 };
        Array.Sort(array);
        int number = 7;
        BinarySearchMethod(array, number);
    }

    static void BinarySearchMethod(int[] array, int number)
    {
        int halfArrayIndex = (array.Length - 1) / 2;
        if (array[halfArrayIndex] == number)
        {
            Console.WriteLine("Position: " + halfArrayIndex);
        }
        if (array[halfArrayIndex] < number)
        {
            for (int i = halfArrayIndex; i < array.Length - 1; i++)
            {
                if (array[i] == number)
                {
                    Console.WriteLine("Position: " + i);
                    break;
                }
            }
        }
        else
        {
            for (int i = halfArrayIndex; i >= 0; i--)
            {
                if (array[i] == number)
                {
                    Console.WriteLine("Position: " + i);
                    break;
                }
            }
        }
    }
}

