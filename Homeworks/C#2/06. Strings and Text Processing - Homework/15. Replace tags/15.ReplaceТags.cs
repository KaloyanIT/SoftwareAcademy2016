namespace ReplaceTags
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    

    //•	Write a program that replaces in a HTML document given as string all the tags
    //  <a href="…">…</a> with corresponding tags [URL=…]…/URL].

    class ReplaceTags
    {
        static void Main()
        {
            string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string pattern = "(?<first><a href=\\\")(?:[a-zA-Z0-9./:\\ ]+)(?<OpenCloseTag>\">)(?:[a-zA-Z0-9 ]+)(?<closeTag></a>)";
            Regex regex = new Regex(pattern);
            Match matches = regex.Match(text);
            var someText = new StringBuilder(text);
            string replaced = someText.Replace(matches.Groups["first"].ToString(), "[URL=").Replace(matches.Groups["OpenCloseTag"].ToString(), "]").Replace(matches.Groups["closeTag"].ToString(), "[/URL]").ToString();
            Console.WriteLine(replaced);

        }
    }
}
