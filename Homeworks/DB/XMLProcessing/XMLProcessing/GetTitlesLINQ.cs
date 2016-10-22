using System;
using System.Linq;
using System.Xml.Linq;

namespace XMLProcessing
{
    public class GetTitlesLINQ
    {
        public static void Titles(string url)
        {
            var doc = XDocument.Load(url);
            var albums = doc.Element("catalogue")
                .Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}