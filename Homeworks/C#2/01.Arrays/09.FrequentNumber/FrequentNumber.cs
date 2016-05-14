using System;
using System.Threading;

class FrequentNumber
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
        int currentNumber = 0;
        int count = 0;
        int bestCount = 0;
        int number = 0;
        while (index < array.Length)
        {
            currentNumber = array[index];
            for (int a = 0; a < array.Length; a++)
            {
                if (currentNumber == array[a])
                {
                    count++;
                }
            }
            if (count > bestCount)
            {
                bestCount = count;
                number = array[index];
            }
            count = 0;
            index++;
        }
        Console.WriteLine("{0} ({1} times)", number, bestCount);
    }
}
