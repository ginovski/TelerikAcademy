namespace ConsoleWebServer.Framework.RequestProcessors
{
    using System.Net;

    public class HeadRequestProcessor : RequestProcessor, IRequestProcessor
    {
        private const string ProcessingMethodNameToLower = "head";

        public override IRequestProcessor NextProcessor
        {
            get
            {
                return new OptionsRequestProcessor();
            }
        }

        public override bool CanProcess(HttpRequest request)
        {
            return request.Method.ToLower() == ProcessingMethodNameToLower;
        }

        protected override void ProcessLogic(HttpRequest request)
        {
            RequestProcessor.Response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, string.Empty);
        }
    }
}