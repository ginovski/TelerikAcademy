namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Net;

    public class RedirectActionResult : ActionResult, IActionResult
    {
        private const string ContentType = "text/plain; charset=utf-8";
        private string location;

        public RedirectActionResult(HttpRequest request, object model, string location)
            : base(request, model)
        {
            this.location = location;
        }

        public override string GetContent()
        {
            return this.Model.ToString();
        }

        public override string GetContentType()
        {
            return ContentType;
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.Redirect;
        }
    }
}