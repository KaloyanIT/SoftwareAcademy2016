using System;
using System.Linq;

//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

class AppearanceCount
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string textNumbers = Console.ReadLine();
        var numbers = textNumbers.Split(' ').ToArray();
        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }
        //int[] array = { 2, 3, 4, 5, 6, 7, 7, 7, 7, 7, 7, 7, 9, 9, 12, 13, 9, 9 };
        int number = int.Parse(Console.ReadLine());
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
        Console.WriteLine(count);
    }
}

