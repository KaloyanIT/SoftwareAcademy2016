using System;

//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] array = { 3, 9, 18, 7, 12, 3, 4, 6, 6, 8 };
        
        int position;
        for (int i = 1; i < array.Length - 1; i++)
        {
            position = i;
            
            if (FindLargerElement(array, position) == false)
            {
                continue;
            }
            else
            {
                Console.WriteLine(position);
               break;
            }

        }
    }

    static bool FindLargerElement(int[] array, int position)
    {
        
        if (array[position] > array[position + 1] && array[position] > array[position - 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

