﻿using System;

class AllocatArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i*5;
        }
        foreach (var i in array)
        {
            Console.WriteLine(i);
        }
    }
}

