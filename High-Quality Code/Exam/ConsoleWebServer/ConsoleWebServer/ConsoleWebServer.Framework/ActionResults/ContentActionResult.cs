namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Net;

    public class ContentActionResult : ActionResult, IActionResult
    {
        private const string ContentType = "text/plain; charset=utf-8";

        public ContentActionResult(HttpRequest request, object model)
            : base(request, model)
        {
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
            return HttpStatusCode.OK;
        }
    }
}