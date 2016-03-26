using System;

//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class GetLargestNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        GetMax(firstNumber, secondNumber);
    }

    static void GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;
        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }
        Console.WriteLine("Bigger number is: " + secondNumber);
        
    }
}

