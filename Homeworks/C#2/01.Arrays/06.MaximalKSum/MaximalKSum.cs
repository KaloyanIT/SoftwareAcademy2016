using System;

class MaximalKSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int sum = 0;       
        for (int a = array.Length - 1; a >= array.Length - k; a--)
        {
            sum += array[a];
        }
        Console.WriteLine(sum);
    }
}

