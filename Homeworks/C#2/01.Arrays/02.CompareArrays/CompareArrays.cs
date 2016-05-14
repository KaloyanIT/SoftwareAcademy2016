using System;

class CompareArrays
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        bool isEqual = true;
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int a = 0; a < secondArray.Length; a++)
        {
            secondArray[a] = int.Parse(Console.ReadLine());
        }

        for (int b = 0; b < firstArray.Length; b++)
        {
            if (firstArray[b] != secondArray[b])
            {
                isEqual = false;
                break;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
       
    }
}

