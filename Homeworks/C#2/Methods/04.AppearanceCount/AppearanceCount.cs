using System;

//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

class AppearanceCount
{
    static void Main()
    {
        int[] array = { 2, 3, 4, 5, 6, 7, 7, 7, 7, 7, 7, 7, 9, 9, 12, 13, 9, 9 };
        int number = 7;
        CountElementsInArray(array, number);
    }

    static void CountElementsInArray(int[] array, int number)
    {
        int count = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (number == array[i])
	        {
                count++;
	        }
        }
        Console.WriteLine("Number: {0} is {1} times in array", number, count);
    }
}

