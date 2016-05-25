using System;

//•	Write a program to check if in a given expression the brackets are put correctly.

class CorrectBrackets
{
    static void Main()
    {
        string text = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(' )
            {
                count++;
            }
            if (text[i] == ')' )
            {
                count--;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
        
    }
}

