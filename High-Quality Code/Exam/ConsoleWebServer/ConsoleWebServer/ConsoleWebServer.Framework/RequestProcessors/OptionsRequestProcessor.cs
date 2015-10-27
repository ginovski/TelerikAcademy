namespace ConsoleWebServer.Framework.RequestProcessors
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;

    using ActionResults;

    public class OptionsRequestProcessor : RequestProcessor, IRequestProcessor
    {
        private const string UriStringFormatMessage = "/{0}/{1}/{{parameter}}";
        private const string ProcessingMethodNameToLower = "options";

        public override IRequestProcessor NextProcessor
        {
            get
            {
                return new StaticFileRequestProcessor();
            }
        }

        public override bool CanProcess(HttpRequest request)
        {
            return request.Method.ToLower() == ProcessingMethodNameToLower;
        }

        protected override void ProcessLogic(HttpRequest request)
        {
            var routes =
                    Assembly.GetEntryAssembly()
                        .GetTypes()
                        .Where(x => x.Name.EndsWith("Controller") && typeof(Controller).IsAssignableFrom(x))
                        .Select(
                            x => new { x.Name, Methods = x.GetMethods().Where(m => m.ReturnType == typeof(IActionResult)) })
                        .SelectMany(
                            x =>
                            x.Methods.Select(
                                m =>
                                string.Format(UriStringFormatMessage, x.Name.Replace("Controller", string.Empty), m.Name)))
                        .ToList();

            RequestProcessor.Response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, string.Join(Environment.NewLine, routes));
        }
    }
}