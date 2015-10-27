namespace ConsoleWebServer.Framework
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class HttpRequest
    {
        private const string InvalidRequestFormat = "Invalid format for the first request line. Expected format: [Method] [Uri] HTTP/[Version]";

        public HttpRequest(string method, string uri, string protocolVersion)
        {
            this.ProtocolVersion = Version.Parse(protocolVersion.ToLower().Replace("HTTP/".ToLower(), string.Empty));
            this.Headers = new SortedDictionary<string, ICollection<string>>();
            this.Uri = uri;
            this.Method = method;
            this.Action = new ActionDescriptor(uri);
        }

        public Version ProtocolVersion { get; protected set; }

        public IDictionary<string, ICollection<string>> Headers { get; protected set; }

        public string Uri { get; private set; }

        public string Method { get; private set; }

        public ActionDescriptor Action { get; private set; }

        public void AddHeader(string name, string value)
        {
            if (!this.Headers.ContainsKey(name))
            {
                this.Headers.Add(name, new HashSet<string>(new List<string>()));
            }

            this.Headers[name].Add(value);
        }

        public HttpRequest Parse(string requestAsText)
        {
            var textReader = new StringReader(requestAsText);
            var firstLine = textReader.ReadLine();
            var requestObject = this.CreateRequest(firstLine);

            string line;
            while ((line = textReader.ReadLine()) != null)
            {
                this.AddHeaderToRequest(requestObject, line);
            }

            return requestObject;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(
                string.Format(
                    "{0} {1} {2}{3}",
                    this.Method,
                    this.Action,
                    "HTTP/",
                    this.ProtocolVersion));
            var headerStringBuilder = new StringBuilder();
            foreach (var key in this.Headers.Keys)
            {
                headerStringBuilder.AppendLine(string.Format("{0}: {1}", key, string.Join("; ", this.Headers[key])));
            }

            sb.AppendLine(headerStringBuilder.ToString());
            return sb.ToString();
        }

        private HttpRequest CreateRequest(string firstRequestLine)
        {
            var firstRequestLineParts = firstRequestLine.Split(' ');
            if (firstRequestLineParts.Length != 3)
            {
                throw new ParserException(InvalidRequestFormat);
            }

            var requestObject = new HttpRequest(firstRequestLineParts[0], firstRequestLineParts[1], firstRequestLineParts[2]);

            return requestObject;
        }

        private void AddHeaderToRequest(HttpRequest request, string headerLine)
        {
            var hp = headerLine.Split(new[] { ':' }, 2);
            var hn = hp[0].Trim();
            var hv = hp.Length == 2 ? hp[1].Trim() : string.Empty;
            request.AddHeader(hn, hv);
        }
    }
}