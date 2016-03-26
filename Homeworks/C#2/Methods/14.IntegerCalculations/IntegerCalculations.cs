using System;

//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

class IntegerCalculations
{
    static void Main()
    {
        //int set = int.Parse(Console.ReadLine());
        //int[] arrayOfNumbers = new int[set];
        int[] arrayOfNUmbers = { 7, 32, 54, 23, 3, 18, 1};
        FindMinimum(arrayOfNUmbers);     
        FindMaximum(arrayOfNUmbers);
        FindAverage(arrayOfNUmbers);
        FindSum(arrayOfNUmbers);
        FindProduct(arrayOfNUmbers);
    }

    static void FindMinimum(int[] array)
    {
        int minumum = int.MaxValue;
        int current = 0;
        for (int i = 0; i < array.Length; i++)
        {
            current = array[i];
            if (current < minumum)
            {
                minumum = current;
            }
        }
        Console.WriteLine("Minimal sum is {0}", minumum);
    }

    static void FindMaximum(int[] array)
    {
        int max = int.MinValue;
        int current = 0;
        for (int i = 0; i < array.Length; i++)
        {
            current = array[i];
            if (current > max)
            {
                max = current;
            }
        }
        Console.WriteLine("Maximal number is {0}", max);
    }

    static void FindAverage(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        int average = sum / array.Length;
        Console.WriteLine("Average sum is {0}", average);
    }

    static void FindSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Sum is {0}", sum);
    }

    static void FindProduct(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        Console.WriteLine("Product is {0}", product);
    }
}

