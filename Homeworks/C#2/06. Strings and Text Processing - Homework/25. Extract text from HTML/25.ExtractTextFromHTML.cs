namespace ExtractTextFromHTML
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    //•	Write a program that extracts from given HTML file its title (if available), 
    //  and its body text without the HTML tags.

    class ExtractTextFromHTML
    {
        static void Main()
        {
            string textHTML = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">TelerikAcademy</a>aims to provide freereal-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
            StringBuilder text = new StringBuilder(textHTML);
            string patternOpenTags = @"";
            Regex openTags = new Regex(patternOpenTags);
            MatchCollection matchesOpenTags = openTags.Matches(text.ToString());
            var a = Regex.Replace(textHTML, "<[^>]*>", String.Empty);
            Console.WriteLine(a);
            
        }
    }
}

