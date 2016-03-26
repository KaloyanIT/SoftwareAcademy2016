using System;

//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

class AllocateArray
{
    static void Main(string[] args)
    {
        int[] array = new int[20];

        //Generate random number to fill the array
        Random generator = new Random();

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = generator.Next(100);
        }

        foreach (var number in array)
        {
            Console.Write(number + ", ");
        }

        int[] multipliedArray = new int[20];

        for (int a = 0; a < multipliedArray.Length - 1; a++)
        {
            multipliedArray[a] = array[a] * 3;

        }

        Console.WriteLine();

        foreach (var multiNumber in multipliedArray)
        {
            Console.Write(multiNumber + ", ");
        }
    

    }
}

