namespace ExtractEMails
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    //•	Write a program for extracting all email addresses from given text.
    //•	All sub-strings that match the format @… should be recognized as emails.


    class ExtractEMails
    {
        static void Main()
        {
            string text = "kaloyan.kostov@yahoo.com is ein sehr shones Mann und na maika ti putkata putka@yahoo.com";
            string pattern = @"([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
