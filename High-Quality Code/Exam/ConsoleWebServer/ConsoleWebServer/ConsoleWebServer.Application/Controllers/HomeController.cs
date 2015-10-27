namespace ConsoleWebServer.Framework
{
    using ActionResults;

    public class HomeController : Controller
    {
        private const string AllowToAllCors = "*";
        private readonly ActionResultFactory actionResultFactory = new ActionResultFactory();

        public HomeController(HttpRequest request) : base(request)
        {
        }

        public IActionResult Index(string param)
        {
            return this.Content("Home page :)");
        }

        public IActionResult LivePage(string param)
        {
            return this.actionResultFactory.GetActionResult(this.Request, "Live page with no caching", ActionResultType.Content, false);
        }

        public IActionResult LivePageForAjax(string param)
        {
            return this.actionResultFactory.GetActionResult(this.Request, "Live page with no caching and CORS", ActionResultType.Content, AllowToAllCors, false);
        }

        public IActionResult Forum(string param)
        {
            return this.Redirect("https://telerikacademy.com/Forum/Home");
        }
    }
}