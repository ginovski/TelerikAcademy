//Using JSON.NET and the Telerik Academy Youtube RSS feed, implement the following:

//The RSS feed is located at https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw
//Download the content of the feed programatically
//You can use WebClient.DownloadFile()
//Parse thе XML from the feed to JSON
//Using LINQ-to-JSON select all the video titles and print the on the console
//Parse the videos' JSON to POCO
//Using the POCOs create a HTML page that shows all videos from the RSS
//Use<iframe>
//Provide a links, that nagivate to their videos in YouTube
namespace ProcessTelerikAcademyRss
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Xml;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Linq;

    internal class Program
    {
        private static string DownloadContent(string rssContentUrl)
        {
            var webClient = new WebClient { Encoding = Encoding.UTF8 };

            return webClient.DownloadString(rssContentUrl);
        }

        private static JObject ConvertToJson(XmlNode document)
        {
            string jsonContent = JsonConvert.SerializeXmlNode(document);
            var jsonObj = JObject.Parse(jsonContent);

            return jsonObj;
        }

        private static IEnumerable<Video> DeserializeVideos(JObject jsonObj)
        {
            return jsonObj["feed"]["entry"].Select(e => JsonConvert.DeserializeObject<Video>(e.ToString()));
        }

        private static void GenerateHtmlResult(IEnumerable<Video> videos)
        {
            var document = new XDocument();
            document.Add(new XDocumentType("html", null, null, null));

            var html = new XElement("html");
            var head = new XElement("head");

            var meta = new XElement("meta");
            meta.SetAttributeValue("charset", "utf-8");

            head.Add(meta);

            var title = new XElement("title");
            title.SetValue("Telerik Academy Videos");

            head.Add(title);
            html.Add(head);

            var body = new XElement("body");
            body.SetAttributeValue("bgcolor", "yellowgreen");

            var h1Title = new XElement("h1");
            h1Title.SetValue("Telerik Academy Videos");
            h1Title.SetAttributeValue("style", "text-align: center");

            body.Add(h1Title);

            foreach (var video in videos)
            {
                var videoDiv = new XElement("div");
                videoDiv.SetAttributeValue("style", "display: inline-block; margin-left: 5%");

                var videoTitle = new XElement("h3");
                videoTitle.SetValue(video.Title);

                var videoLink = new XElement("a");
                videoLink.SetValue("Video");
                videoLink.SetAttributeValue("href", string.Format("https://www.youtube.com/watch?v={0}", video.VideoId));

                videoDiv.Add(videoLink);
                videoDiv.Add(videoTitle);

                var videoIframe = new XElement("iframe");
                videoIframe.SetValue(string.Empty);
                videoIframe.SetAttributeValue("src", string.Format("https://www.youtube.com/embed/{0}", video.VideoId));
                videoIframe.SetAttributeValue("width", 500);
                videoIframe.SetAttributeValue("height", 300);

                videoDiv.Add(videoIframe);
                body.Add(videoDiv);
            }

            html.Add(body);
            document.Add(html);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            var writer = XmlWriter.Create("../../videos.html", settings);

            document.Save(writer);
            writer.Close();
        }

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string rssContentUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string rssContent = DownloadContent(rssContentUrl);

            XmlDocument document = new XmlDocument();
            document.LoadXml(rssContent);

            var jsonObj = ConvertToJson(document);
            var videos = DeserializeVideos(jsonObj);

            foreach (var video in videos)
            {
                Console.WriteLine(video.Title);
            }

            GenerateHtmlResult(videos);
        }
    }
}