using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

//Problem 8
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

class NumberAsArray
{
    static List<int> sum = new List<int>();
    static void Main()
    {
        //string number1 = Console.ReadLine();
        //string number2 = Console.ReadLine();
        string number1 = "3 9 3 8 9 9 9 8 3 9 8 3 9 2 8";
        string number2 = "9 3 8 3 9 3 8 9 3 8 3 9 8 3 2";
        //string number1 = "9 9 9 9 9 9";
        //string number2 = "9 9 9 9 9 9";

        //if (IsDigitsOnly(number1) == false|| IsDigitsOnly(number2) == false)
        //{
        //    Console.WriteLine("This is not a number.");
        //}

        
        int[] arrayOfNumbers = number1.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        int[] arrayOfNumbers2 = number2.Split(' ').Select(m => Convert.ToInt32(m)).ToArray();
        PrintArray(arrayOfNumbers);
        Console.WriteLine();
        Console.WriteLine("+");
        PrintArray(arrayOfNumbers2);
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------");
        SumOfTwoArrays(arrayOfNumbers, arrayOfNumbers2);
        
        int[] arrayResult = sum.ToArray();        
        PrintArray(arrayResult);
       
    }

    
    //static bool IsDigitsOnly(string str)
    //{
    //    foreach (char c in str)
    //    {
    //        if (c < '0' || c > '9' )
    //        {
                
    //            return false;
    //        }
            
    //    }

    //    return true;
    //}

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
	    {
		    Console.Write(item + " ");
	    }
    }

    static void SumOfTwoArrays(int[] array, int[] array1)
    {
        int addToSum = 0;
        array.Reverse();
        array1.Reverse();       
        for (int i = 0; i < array.Length; i++)
        {
            
            int timeSum = array[i] + array1[i] + addToSum;
            if (timeSum > 9)
            {
                addToSum = 0;
                if (timeSum > 19)
                {
                    addToSum = 2;
                    timeSum -= 20;
                    sum.Add(timeSum);
                }
                else
                {
                    addToSum = 1;
                    timeSum -= 10;
                    sum.Add(timeSum);
                }
            }
            else
            {
                addToSum = 0;
                sum.Add(timeSum);
            }
        }
        if (addToSum > 0)
        {
            sum.Insert(0 , addToSum);
        }
    }


}

