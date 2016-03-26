using System;

//•	Write a program to check if in a given expression the brackets are put correctly.

class CorrectBrackets
{
    static void Main()
    {
        string text = "()(a + b))";
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
            Console.WriteLine("Brackets are put correctly");
        }
        else
        {
            Console.WriteLine("Brackets are not put correctly");
        }
        
    }
}

