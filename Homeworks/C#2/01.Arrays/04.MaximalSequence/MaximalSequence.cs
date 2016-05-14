using System;
using System.Threading;

class MaximalSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int index = 0;
        int sequence = 1;
        int bestSequence = 1;
        for (int a = 0; a < array.Length; a++)
        {
            index = a;
            while (index < array.Length - 1)
            {
                if (array[index] == array[index + 1])
                {
                    sequence++;
                }
                else
                {
                    break;
                }
                index++;
            }
            if (sequence > bestSequence)
            {
                bestSequence = sequence;               
            }
            sequence = 1;
        }
        Console.WriteLine(bestSequence);
    }
}
