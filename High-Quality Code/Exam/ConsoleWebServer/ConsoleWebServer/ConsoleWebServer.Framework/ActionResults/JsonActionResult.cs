namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Net;

    using Newtonsoft.Json;

    public class JsonActionResult : ActionResult, IActionResult
    {
        private const string ContentType = "application/json";

        public JsonActionResult(HttpRequest request, object model)
            : base(request, model)
        {
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.OK;
        }

        public override string GetContent()
        {
            return JsonConvert.SerializeObject(this.Model);
        }

        public override string GetContentType()
        {
            return ContentType;
        }
    }
}