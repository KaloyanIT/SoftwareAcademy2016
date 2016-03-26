using System;

//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class SelectionSort
{
    static void Main()
    {
        int[] array = { 7, 3, 2, 12, 28, 5, 8, 4, 1 };

        Console.Write("Unsorted: ");
        PrintArray(array);
        SelectionSortAlgo(array);
        Console.Write("Sorted: ");
        PrintArray(array);
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

    static void PrintArray (int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }

    
}

