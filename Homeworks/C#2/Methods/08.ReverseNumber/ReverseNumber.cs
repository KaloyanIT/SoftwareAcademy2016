using System;

//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

class ReverseNumber
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        ReverseNumbers(number);
    }

    static void ReverseNumbers(decimal number)
    {
        string text = number.ToString();
        for (int i = text.Length - 1; i > 0; i--)
        {
            Console.Write(text[i]);
        }
    }

}

