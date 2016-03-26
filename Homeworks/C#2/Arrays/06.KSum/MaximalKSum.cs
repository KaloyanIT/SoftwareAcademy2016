using System;
using System.Linq;

//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

class MaximalKSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        if (k > n)
        {
            Console.WriteLine("K must be < N");
        }
        
        int[] array = new int[n];
        Console.WriteLine("Fill the array:");
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.Write(i + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;

        for (int write = 0; write < array.Length; write++)
        {
            for (int sort = 0; sort < array.Length - 1; sort++)
            {
                if (array[sort] > array[sort + 1])
                {
                    temp = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = temp;
                }
            }
        }

        

        Array.Reverse(array);
        int sum = 0;
        Console.Write("Biggest numbers are: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(array[i] + ", ");
            sum += array[i];
        }
        Console.WriteLine("Sum is: " + sum);

    }
}

