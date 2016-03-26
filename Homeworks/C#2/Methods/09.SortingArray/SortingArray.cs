using System;
using System.Linq;

//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

class SortingArray
{
    static void Main()
    {
        int[] array = {12, 18, 2, 8, 13, 54, 32, 28, 30, 51, 78, 21, 87 };
        Console.Write("Enter index to start from: ");
        int startIndex = int.Parse(Console.ReadLine());
        FindMaximalElement(array, startIndex);
        SelectionSortAlgo(array);
        PrintArray(array);
        SelectionSortAlgoDescendingOrder(array);
        PrintArray(array);
    }

    static void FindMaximalElement(int[] array, int startIndex)
    {
        int biggestNum = 0;
        for (int i = startIndex; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                biggestNum = array[i + 1];
            }
        }
        Console.WriteLine(biggestNum);
    }

    static void SelectionSortAlgo(int[] array)
    {
        int temp = 0;
        for (int a = 0; a < array.Length; a++)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    temp = 0;
                }
            }
        }
    }

    static void SelectionSortAlgoDescendingOrder(int[] array)
    {
        int temp = 0;
        for (int a = 0; a < array.Length; a++)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    temp = 0;
                }
            }
        }
    }
    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }

    //static bool IsSorted(int[] array)
    //{
    //    for (int i = 0; i < array.Length - 1; i++)
    //    {
    //        if (array[i] > array[i + 1])
    //        {
    //            return false;
    //        }          
    //    }
    //    return true;
    //}
}

