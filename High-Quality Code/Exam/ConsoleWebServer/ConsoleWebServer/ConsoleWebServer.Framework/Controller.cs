namespace ConsoleWebServer.Framework
{
    using ActionResults;

    public abstract class Controller
    {
        private readonly ActionResultFactory actionResultFactory = new ActionResultFactory();

        protected Controller(HttpRequest request)
        {
            this.Request = request;
        }

        public HttpRequest Request { get; private set; }

        protected IActionResult Content(object model)
        {
            return this.actionResultFactory.GetActionResult(this.Request, model, ActionResultType.Content);
        }

        protected IActionResult Json(object model)
        {
            return this.actionResultFactory.GetActionResult(this.Request, model, ActionResultType.Json);
        }

        protected IActionResult Redirect(string location)
        {
            return this.actionResultFactory.GetRedirectActionResult(this.Request, string.Empty, location);
        }
    }
}