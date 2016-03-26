namespace EnterNumbers
{
    using System;

    /*•	Write a method ReadNumber(int start, int end) that enters an integer number in a given 
             * range [start…end].
                o	If an invalid number or non-number text is entered, the method should throw an exception.
              •	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 
             * 1 < a1 < … < a10 < 100*/


    class EnterNumbers
    {
        static void Main()
        {
            //ReadNumber(5, 15);
            Read10Numbers(10, 100);
        }

        static void ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new Exception("Invalid number");
            }
        }

        static void Read10Numbers(int start, int end)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < start || array[i] > end)
                {
                    throw new Exception("Invalid number");
                }
            }
        }
    }
}