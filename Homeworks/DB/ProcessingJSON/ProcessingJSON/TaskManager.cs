using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProcessingJSON
{
    public class TaskManager
    {
        public string ConvertToJSON(XmlDocument xml)
        {
            string convertedJSON = JsonConvert.SerializeXmlNode(xml);
            return convertedJSON;
        }

        public IEnumerable<Video> GetTitles(JObject jObject)
        {
            var titles = jObject["feed"]["entry"]
                .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            return titles;
        }

        public JObject GetJObject(XmlDocument doc)
        {
            string json = JsonConvert.SerializeXmlNode(doc);
            var jObject = JObject.Parse(json);

            return jObject;
        }


        public string GetHtmlString(IEnumerable<Video> videos)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<!DOCTYPE html><html><body>");
            foreach (var video in videos)
            {
                html.AppendFormat("<div style=\"float:left; width: 420px; height: 450px; padding:10px; " +
                                  "margin:5px; background-color:grey; border-radius:10px\">" +
                                  "<iframe width=\"420\" height=\"345\" " +
                                  "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "<h3>{2}</h3><a href=\"{0}\">Go to YouTube</a></div>",
                                  video.Link.Href, video.Id, video.Title);
            }
            html.Append("</body></html>");

            return html.ToString();
        }

        public void PrintTitles(IEnumerable<Video>titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title.Title);
            }

        }

        public void SaveHtml(string html, string htmlName)
        {
            using (StreamWriter writer = new StreamWriter("../../" + htmlName, false, Encoding.UTF8))
            {
                writer.Write(html);
            }

            var currentDir = Directory.GetCurrentDirectory();
            var htmlDir = currentDir.Substring(0, currentDir.IndexOf("bin\\Debug")) + htmlName;

            Console.WriteLine("Html dir: {0}", htmlDir);
        }

    }
}