using System;

//• Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

class SubStringInText
{
    static void Main()
    {
        string text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'i' && text[i + 1] == 'n')
            {
                count++;
            }
        }
        Console.WriteLine(count);

    }
}

