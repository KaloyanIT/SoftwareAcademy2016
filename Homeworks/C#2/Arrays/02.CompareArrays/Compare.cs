using System;
using System.Runtime.InteropServices;

//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

class Compare
{
    static void Main(string[] args)
    {
        
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];

        for (int i = 0; i < firstArray.Length - 1; i++)
        {
            Console.Write("Add numbers to first array: ");
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int a = 0; a < secondArray.Length - 1; a++)
        {
            Console.Write("Add numbers to second array: ");
            secondArray[a] = int.Parse(Console.ReadLine());
        }

        for (int b = 0; b < firstArray.Length - 1; b++)
        {
            if (firstArray[b] == secondArray[b])
            {
                Console.WriteLine(firstArray[b] + " = " + secondArray[b]);
            }
            if (firstArray[b] > secondArray[b])
            {
                Console.WriteLine(firstArray[b] + " > " + secondArray[b]);
            }
            if(firstArray[b]  < secondArray[b])
            {
                Console.WriteLine(firstArray[b] + " < " + secondArray[b]);
            }
        }

       

    }
}
