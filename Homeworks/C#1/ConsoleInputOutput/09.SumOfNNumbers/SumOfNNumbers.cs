﻿using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}

