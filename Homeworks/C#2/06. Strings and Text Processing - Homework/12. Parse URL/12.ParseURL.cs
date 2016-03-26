namespace ParseURL
{
    using System;
    using System.Text.RegularExpressions;
    /*•	Write a program that parses an URL address given in the format:
             * [protocol]://[server]/[resource] and extracts from it the [protocol],
             * [server] and [resource] elements.*/

    class ParseURL
    {
        static void Main()
        {
            string text = "http://telerikacademy.com/Courses/Details/212";
            string pattern = @"(?<protocol>^[a-z]+)://(?<server>\w+\.\w+)(?<resource>[A-Za-z0-9\/]+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);

            Console.WriteLine(match.Groups.Count);
            Console.WriteLine("[protocol]: {0}", match.Groups["protocol"]);
            Console.WriteLine("[server]: {0}", match.Groups["server"]);
            Console.WriteLine("[resource]: {0}", match.Groups["resource"]);
        }
    }
}
