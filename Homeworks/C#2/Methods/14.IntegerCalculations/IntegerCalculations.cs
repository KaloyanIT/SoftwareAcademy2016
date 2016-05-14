using System;
using System.Linq;

//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

class IntegerCalculations
{
    static void Main()
    {
        //int set = int.Parse(Console.ReadLine());
        //int[] arrayOfNumbers = new int[set];
        
        string textNumbers = Console.ReadLine();
        var numbers = textNumbers.Split(' ').ToArray();
        long[] arrayOfNUmbers = new long[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            arrayOfNUmbers[i] = long.Parse(numbers[i]);
        }
        FindMinimum(arrayOfNUmbers);     
        FindMaximum(arrayOfNUmbers);
        FindAverage(arrayOfNUmbers);
        FindSum(arrayOfNUmbers);
        FindProduct(arrayOfNUmbers);
    }

    static void FindMinimum(long[] array)
    {
        long minumum = long.MaxValue;
        long current = 0;
        for (int i = 0; i < array.Length; i++)
        {
            current = array[i];
            if (current < minumum)
            {
                minumum = current;
            }
        }
        Console.WriteLine(minumum);
    }

    static void FindMaximum(long[] array)
    {
        long max = long.MinValue;
        long current = 0;
        for (int i = 0; i < array.Length; i++)
        {
            current = array[i];
            if (current > max)
            {
                max = current;
            }
        }
        Console.WriteLine(max);
    }

    static void FindAverage(long[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = (double)sum / (double)array.Length;
        Console.WriteLine("{0:F2}", average);
    }

    static void FindSum(long[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }

    static void FindProduct(long[] array)
    {
        long product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        Console.WriteLine(product);
    }
}

