using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace ProcessingJSON
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //string url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string filePath = "../../telerikFeed.xml";
            //DownloadFile(url, filePath);
            var document = new XmlDocument();
            document.Load(filePath);
            var solver = new TaskManager();


            string parsedJson = solver.ConvertToJSON(document);
            var jObject = solver.GetJObject(document);
            var titles = solver.GetTitles(jObject);
            solver.PrintTitles(titles);
            var html = solver.GetHtmlString(titles);
            solver.SaveHtml(html, "telerikFeedHtml.html");



        }

        static void DownloadFile(string url, string filePath)
        {
            var downloader = new WebClient();

            downloader.DownloadFile(url, filePath);
        }

    }
}
