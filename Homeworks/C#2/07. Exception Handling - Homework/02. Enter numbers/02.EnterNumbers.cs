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
            Read10Numbers(0, 100);
        }        

        static void Read10Numbers(int start, int end)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {

                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    throw new FormatException();
                }                
            }
            bool forPrint = true;
            for (int a = 0; a < array.Length - 1; a++)
            {
                if (array[a] < start || array[a] > end || array[a] > array[a + 1])
                {
                    forPrint = false;
                    //throw new Exception();
                    Console.WriteLine("Exception");
                    break;
                }                            
            }
            if (forPrint)
            {
                Console.Write("1 < ");
                for (int b = 0; b < array.Length; b++)
                {
                    
                    
                        Console.Write(array[b] + " < ");
                    
                }
                Console.Write("100");
            }
        }
    }
}