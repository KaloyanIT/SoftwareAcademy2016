using System;

namespace XMLProcessing
{
    public class StartUp
    {
        static void Main()
        {
            string url = "../../catalogue.xml";
            //DeleteAlbum.Delete(url); --> it works, but i comment it because i need the xml document
            DomParser.Parse(url);
            //Console.WriteLine("XPathParser");
            //XPathParse.Parser(url);
            Console.WriteLine("titleess-------------");
            GetTitles.Titles(url);
            Console.WriteLine("LINQ TITLES");
            GetTitlesLINQ.Titles(url);
            Console.WriteLine();
            XMLCreator.CreatePersonXML();


        }
    }
}