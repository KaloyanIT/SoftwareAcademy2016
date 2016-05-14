//using System;

//class MaximalSum
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
//        int sum = 0;
//        int bestSum = 0;
//        int sequence = 0;
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            array[i] = int.Parse(Console.ReadLine());
//            sum += array[i];
//            if (sum < 0)
//            {
//                sum = 0;
//                continue;
//            }
//            else
//            {
//                if (sum > bestSum)
//                {                   
//                    sequence++;
//                    bestSum = sum;
//                }
//            }
//        }        
//        Console.WriteLine(bestSum);
//    }
//}

using System;


class MaximalSum
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        int currentSum = 0;
        int maxSum = int.MinValue;


        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

            currentSum += array[i];

            if (currentSum < array[i])
            {
                currentSum = array[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine(maxSum);
    }
}