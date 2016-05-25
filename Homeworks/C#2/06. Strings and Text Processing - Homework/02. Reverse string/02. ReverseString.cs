using System;

//•	Write a program that reads a string, reverses it and prints the result at the console.

class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        for (int i  = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
    }
}
