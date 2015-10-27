namespace ConsoleWebServer.Application
{
    using System;
    using System.Linq;

    using Framework;

    using Framework.ActionResults;

    public class ApiController : Controller
    {
        private const string RefererHeaderName = "Referer";
        private const string InvalidRefererExceptionName = "Invalid referer!";
        private const string DateFormat = "yyyy-MM-dd";
        private const string MoreDateInfoStringFormat = "Data available for {0}";

        public ApiController(HttpRequest request) : base(request)
        {
        }

        public IActionResult ReturnMe(string param)
        {
            return this.Json(new { param });
        }

        public IActionResult GetDateWithCors(string domainName)
        {
            var requestReferer = string.Empty;
            if (this.Request.Headers.ContainsKey(RefererHeaderName))
            {
                requestReferer = this.Request.Headers[RefererHeaderName].FirstOrDefault();
            }

            if (string.IsNullOrWhiteSpace(requestReferer) || !requestReferer.Contains(domainName))
            {
                throw new ArgumentException(InvalidRefererExceptionName);
            }

            var actionResultFactory = new ActionResultFactory();

            return actionResultFactory.GetActionResult(
                this.Request,
                new
                {
                    date = DateTime.Now.ToString(DateFormat),
                    moreInfo = string.Format(MoreDateInfoStringFormat, domainName)
                },
                ActionResultType.Json,
                domainName);
        }
    }
}