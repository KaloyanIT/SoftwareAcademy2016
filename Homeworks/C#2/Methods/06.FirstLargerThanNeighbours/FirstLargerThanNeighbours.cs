using System;
using System.Linq;

//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

class FirstLargerThanNeighbours
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
            if (count == 1)
            {
                count = position;
                break;            
            }
        }
        return count;
    }

}

