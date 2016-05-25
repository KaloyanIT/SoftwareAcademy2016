using System.Collections.Generic;



using System;
using System.Text.RegularExpressions;
/*•	Write a program that parses an URL address given in the format:
            * [protocol]://[server]/[resource] and extracts from it the [protocol],
            * [server] and [resource] elements.*/

class ParseURL
{
    static void Main()
    {
        // 100 / 100

        //var test = "ftp://www.telerik-academy.com/Courses/Courses/Details/212";

        var format = new string[]
        {
            "[protocol] = {0}",
            "[server] = {0}",
            "[resource] = /{0}"
        };

        var toParse = Console.ReadLine();

        //var URLPattern = new Regex(@"(?<Protocol>\w+)://(?<Server>[\w\.]+)(?<Content>/.*)");

        // Expressions in Brackets are captured in groups.
        // Anything outside of the brackets is matched but 
        // not captured.
        // Optionally can name each group with <Name>
        // 
        var URLPattern = (@"(\w*)://(.*)/(.*)");

        var Match = Regex.Match(toParse, URLPattern, RegexOptions.RightToLeft);

        var toPrint = new List<object>();

        foreach (var group in Match.Groups)
        {
            if (group.ToString() != toParse)
            {
                toPrint.Add(group);
            }
        }

        for (int index = 0; index < 3; index++)
        {
            Console.WriteLine(string.Format(format[index], toPrint[index]));
        }

    }
}

