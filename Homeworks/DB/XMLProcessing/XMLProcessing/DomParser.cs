using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLProcessing
{
    public class DomParser
    {
        public static void Parse(string url)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNode rootNode = doc.DocumentElement;
            
            foreach (XmlNode node in rootNode)
            {
                try
                {
                    Console.WriteLine("__________________________________________________");
                    Console.WriteLine("Album name: {0}", node["name"].InnerText);
                    Console.WriteLine("Album artist: {0}", node["artist"].InnerText);
                    Console.WriteLine("Album year: {0}", node["year"].InnerText);
                    Console.WriteLine("Album price: {0}$", node["price"].InnerText);
                    foreach (XmlNode childNode in node.LastChild.ChildNodes)
                    {
                        Console.WriteLine("Song title: {0}", childNode["title"].InnerText);
                        Console.WriteLine("Song duration: {0} min", childNode["duration"].InnerText);
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Deleted");
                }
            }
            
        }
    }
}
