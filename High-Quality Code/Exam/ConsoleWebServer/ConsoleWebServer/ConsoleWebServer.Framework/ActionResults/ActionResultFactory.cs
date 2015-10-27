namespace ConsoleWebServer.Framework.ActionResults
{
    public class ActionResultFactory
    {
        private const string AccessControlAllowOriginHeaderName = "Access-Control-Allow-Origin";
        private const string CacheControlHeaderName = "Cache-Control";
        private const string LocationHeaderName = "Location";

        public ActionResult GetActionResult(HttpRequest request, object model, ActionResultType actionResultType, bool hasCache = true)
        {
            ActionResult actionResult = null;
            if (actionResultType == ActionResultType.Content)
            {
                actionResult = new ContentActionResult(request, model);
            }
            else if (actionResultType == ActionResultType.Json)
            {
                actionResult = new JsonActionResult(request, model);
            }

            if (!hasCache)
            {
                actionResult.AddHeader(CacheControlHeaderName, "private, max-age=0, no-cache");
            }

            return actionResult;
        }

        public ActionResult GetActionResult(HttpRequest request, object model, ActionResultType actionResultType, string corsSettings, bool hasCache = true)
        {
            ActionResult actionResult = this.GetActionResult(request, model, actionResultType, hasCache);

            actionResult.AddHeader(AccessControlAllowOriginHeaderName, corsSettings);

            return actionResult;
        }

        public ActionResult GetRedirectActionResult(HttpRequest request, object model, string location, bool hasCache = true)
        {
            ActionResult actionResult = new RedirectActionResult(request, model, location);

            actionResult.AddHeader(LocationHeaderName, location);
            if (!hasCache)
            {
                actionResult.AddHeader(CacheControlHeaderName, "private, max-age=0, no-cache");
            }

            return actionResult;
        }

        public ActionResult GetRedirectActionResult(HttpRequest request, object model, string corsSettings, string location, bool hasCache = true)
        {
            ActionResult actionResult = this.GetRedirectActionResult(request, model, location, hasCache);

            actionResult.AddHeader(AccessControlAllowOriginHeaderName, corsSettings);

            return actionResult;
        }
    }
}