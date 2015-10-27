namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using System.Net;

    public abstract class ActionResult : IActionResult
    {
        public readonly object Model;

        public ActionResult(HttpRequest request, object model)
        {
            this.Model = model;
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public HttpRequest Request { get; private set; }

        public List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

        public void AddHeader(string headerName, string value)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(headerName, value));
        }

        public abstract HttpStatusCode GetStatusCode();

        public abstract string GetContent();

        public abstract string GetContentType();

        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(
                this.Request.ProtocolVersion,
                this.GetStatusCode(),
                this.GetContent(),
                this.GetContentType());

            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}