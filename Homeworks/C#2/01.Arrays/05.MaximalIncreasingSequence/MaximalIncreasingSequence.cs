//using System;
//using System.Runtime.CompilerServices;
//using System.Threading;

//class MaximalIncreasingSequence
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        int count = 1;
//        int bestCount = 1;
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = int.Parse(Console.ReadLine());

//        }

//        for (int a = 0; a < array.Length - 1; a++)
//        {
//            if (array[a] + 1 == array[a + 1])
//            {
//                count++;
//            }          
//            if (count > bestCount)
//            {
//                bestCount = count;
//            }
//            if (array[a] + 1 != array[a + 1])
//            {
//                count = 1;
//            }        
//        }
//        Console.WriteLine(bestCount);
//    }
//}


using System;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int currentNumber = int.Parse(Console.ReadLine());
        array[0] = currentNumber;
        int count = 1;
        int bestCount = 0;
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            if (currentNumber < array[i])
            {
                count++;
            }
            else
            {
                if (count > bestCount)
                {
                    bestCount = count;
                    count = 1;
                }
                count = 1;
                currentNumber = array[i];
            }
        }
        Console.WriteLine(bestCount);
    }
}