namespace ExtractSentences
{
    using System;
    using System.Text;
    using System.Linq;

    //•	Write a program that extracts from a given text all sentences containing given word.

    class ExtractSentences
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string givenWord = "in";
            char[] splitsChars = { '.' };
            string[] spiltted = text.Split(splitsChars, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine();
            for (int i = 0; i < spiltted.Length; i++)
            {
               if( spiltted[i].IndexOf(" in ") > 1)
               {
                   Console.Write(spiltted[i] + ".");
               }
            }
        }
    }
}

