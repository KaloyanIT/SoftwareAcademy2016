using System;
using System.Xml;

namespace XMLProcessing
{
    public class DeleteAlbum
    {
        public static void Delete(string url)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);

            XmlNode rootNode = doc.DocumentElement;
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                try
                {


                    if (int.Parse(node["price"].InnerText) > 20)
                    {
                        node.InnerText = "";
                        doc.Save(url);
                    }
                }
                catch (NullReferenceException)
                {
                    
                }
            }
        }
    }
}