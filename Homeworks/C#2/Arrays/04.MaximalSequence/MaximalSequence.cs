using System;
using System.Linq;

//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

//var seq = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

//int[] max = seq.Select((n, i) => new { Value = n, Index = i })
//    .OrderBy(s => s.Value)
//    .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
//    .GroupBy(s => new { s.Value, s.Diff })
//    .OrderByDescending(g => g.Count())
//    .First()
//    .Select(f => f.Value)
//    .ToArray();
//foreach (var item in max)
//{
//    Console.WriteLine(item);
//}

class MaximalSequence
{
    private static int BestNumber;
    private static int BestSequenceLength;
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
        FindMaxSequence(array);
        Console.WriteLine();
        PrintMaxSequence();
    }

    static void FindMaxSequence(int[] array)
    {
        int currentNumber = 0;
        int sequenceLength = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentNumber = array[i];
                
                sequenceLength++;
                if (sequenceLength > BestSequenceLength)
                {
                    BestSequenceLength = sequenceLength;
                    BestNumber = currentNumber;
                }
            }
            else
            {
                sequenceLength = 0;
            }
        }
    }

    private static void PrintMaxSequence()
    {
        Console.Write("The Maximal Sequence is: { ");
        for (int i = 0; i <= BestSequenceLength; i++)
        {
            Console.Write(BestNumber + ", ");
        }
        Console.Write(" }");
        Console.WriteLine();
    }
}

