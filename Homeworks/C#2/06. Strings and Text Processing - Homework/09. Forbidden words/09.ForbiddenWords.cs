namespace FobiddenWords
{
    using System;
    using System.Linq;
    using System.Text;

    /* •	We are given a string containing a list of forbidden words and a text containing some of 
            * these words.
              •	Write a program that replaces the forbidden words with asterisks.*/


    class ForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
            char[] splitChars = { ' ', '.' };
            string[] splitted = text.Split(splitChars).ToArray();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < splitted.Length; i++)
            {
                for (int a = 0; a < forbiddenWords.Length; a++)
                {
                    if (string.Equals(splitted[i], forbiddenWords[a], StringComparison.CurrentCulture))
                    {
                        result.Append('*', splitted[i].Length);
                        result.Append(' ');
                        i++;
                    }


                }                   
                result.Append(splitted[i] + ' ');
            }
            Console.WriteLine(result.ToString());
        }
    }
}

