using System;

//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

class MaximalSequence
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int bestSum = 0;
        int sequence = 0;
        int start = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            sum += array[i];
            if (sum < 0)
            {
                sum = 0;
                continue;
            }
            else
            {
                if (sum > bestSum)
                {
                    start = array[i];
                    sequence++;
                    bestSum = sum;
                }
            }
        }
        Console.Write("Sequence is: ");
        for (int a = start; a < start + sequence; a++)
        {
            Console.Write(array[a] + ", ");
        }
        Console.WriteLine("Maximal sum: "  + bestSum);
    }
}

