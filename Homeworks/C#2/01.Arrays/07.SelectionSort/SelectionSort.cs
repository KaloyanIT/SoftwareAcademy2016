using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int tmp, min_key;

        for (int j = 0; j < n - 1; j++)
        {
            min_key = j;

            for (int k = j + 1; k < n; k++)
            {
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }

            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

