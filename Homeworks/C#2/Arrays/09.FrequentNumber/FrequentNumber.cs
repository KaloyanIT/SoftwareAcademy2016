using System;

//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

class FrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int currentElement = 0;
        int sequence = 0;
        int maxSequence = 0;
        int frequentNumber = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            currentElement = array[i];
            for (int a = 0; a < array.Length - 1; a++)
            {
                if (array[i] == array[a])
                {
                    sequence++;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        frequentNumber = array[i];
                    }
                }
            }
            sequence = 0;
        }
        Console.WriteLine("Number: " + frequentNumber);
        Console.WriteLine("Times: " + maxSequence);

    }
}

