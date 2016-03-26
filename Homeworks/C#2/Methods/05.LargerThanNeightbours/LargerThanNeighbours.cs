using System;

//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

class LargerThanNeighbours
{
    static void Main()
    {
        int[] array = { 3, 9, 18, 7, 12, 3, 4, 6, 6, 8 };
        int position = 2;
        FindLargerElement(array, position);
    }

    static void FindLargerElement(int[] array, int position)
    {
        if (position == 0 || position == array.Length - 1)
        {
            Console.WriteLine("Has only one neighbour.");
        }     
        if (array[position] > array[position + 1] && array[position] > array[position - 1])
        {
            Console.WriteLine(array[position] + " is larger than its neighbours.");
        }
        else
        {
            Console.WriteLine(array[position] + " isn't larger than its neighbours.");
        }
    }


}

