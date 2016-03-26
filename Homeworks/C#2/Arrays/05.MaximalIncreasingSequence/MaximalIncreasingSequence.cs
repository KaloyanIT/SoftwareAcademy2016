using System;

//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

class MaximalIncreasingSequence
{
    
    private static int BestSequence;
    private static int SequenceEnd;
    static void Main()
    {
        Console.Write("Write array lenght:");
        int lengthArray = int.Parse(Console.ReadLine());

        int[] array = new int[lengthArray];
        Console.WriteLine("Enter numbers to array");
        for (int i = 0; i < lengthArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Array is: ");
        Console.Write("{ ");
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
        Console.Write(" }");
        Console.WriteLine();
        FindMaximalIncreasingSequence(array);
        Console.WriteLine();
        PrintSequence(array);
    }

    static void FindMaximalIncreasingSequence(int[] array)
    {
        int currentNumber = 0;
        int sequenceStart = 0;
        int sequence = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1])
            {
                sequence++;
                if (sequence > BestSequence)
                {
                    BestSequence = sequence;
                    //sequence = 0;
                    SequenceEnd = i;
                }

            }
            else
            {
                sequence = 0;
            }
        }
    }

    static void PrintSequence(int[] array)
    {
        int sequenceLength = SequenceEnd - BestSequence;
        Console.Write("The Maximal Sequence is: { ");
        for (int i = sequenceLength; i <= SequenceEnd; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(" }");
        Console.WriteLine();
    }
}

