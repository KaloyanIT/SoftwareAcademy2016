namespace SeriesOfLetters
{

    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Linq;

    //•	Write a program that reads a string from the console and replaces all series 
    //  of consecutive identical letters with a single one.

    class SeriesOfLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            string pattern = @"[a-zA-Z]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            StringBuilder noEquelsSymbols = new StringBuilder();
            for (int i = 0; i < matches.Count - 1; i++)
            {
                noEquelsSymbols.Append(matches[i]);
               while (true)
	            {
                    if (matches[i].ToString() == matches[i + 1].ToString())
                    {                        
                        i++;
                        if (i >= matches.Count - 1)
                        {
                            i--;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
	            }
               //if (i >= matches.Count - 1)
               //{
               //    break;
               //}
            }
            Console.WriteLine(noEquelsSymbols.ToString());
        }
    }
}
