using System;
using System.Xml;

namespace XMLProcessing
{
    public class GetTitles
    {
        public static void Titles(string url)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode)
            {
                foreach (XmlNode childNode in node.LastChild.ChildNodes)
                {
                    Console.WriteLine(childNode["title"].InnerText);
                }
            }
        }
    }
}