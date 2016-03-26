using System;

//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).

class FindSumInArray
{
    static void Main(string[] args)
    {
        int[] array = { 4, 3, 1, -6, 8, 9, 8 };
        int maxSum = 11;
        int sum = 0;
        int startSequence = 0;
        int endSequence = 0;
        bool isPositive = true;
        for (int x = 0; x < array.Length - 1; x++)
        {
            if (array[x] < 0)
            {
                isPositive = false;
                break;
            }
        }
        if (isPositive == true)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                sum += array[i];
                if (sum > maxSum)
                {
                    sum = 0;
                    startSequence = i;
                    i--;
                }
                if (sum == maxSum)
                {
                    endSequence = i;
                }
            }
            Console.Write("Sequence with sum {0} is: ", maxSum);
            for (int a = startSequence; a <= endSequence; a++)
            {
                Console.Write(array[a] + ", ");
            }
        }
        else
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int b = i; b < array.Length - 1; b++)
                {
                    sum += array[b];
                    if (sum > maxSum)
                    {
                        sum = 0;
                        break;
                    }
                    if (sum == maxSum)
                    {
                        endSequence = b;
                        startSequence = i;
                    }
                }
            }
            Console.Write("Sequence with sum {0} is: ", maxSum);
            for (int a = startSequence; a <= endSequence; a++)
            {
                Console.Write(array[a] + ", ");
            }
           
        }
    }
}

