using System;

//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically(letter by letter).

class CompareCharArrays
{
    private static void Main(string[] args)
    {
        char[] firstArray = new char[5];
        char[] secondArray = new char[5];

        for (int i = 0; i < firstArray.Length - 1; i++)
        {
            Console.Write("Add char to first array: ");
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        for (int a = 0; a < secondArray.Length - 1; a++)
        {
            Console.Write("Add char to second array: ");
            secondArray[a] = char.Parse(Console.ReadLine());
        }

        for (int b = 0; b < firstArray.Length - 1; b++)
        {
            if (firstArray[b] == secondArray[b])
            {
                Console.WriteLine(firstArray[b] + " = " + secondArray[b]);
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}

