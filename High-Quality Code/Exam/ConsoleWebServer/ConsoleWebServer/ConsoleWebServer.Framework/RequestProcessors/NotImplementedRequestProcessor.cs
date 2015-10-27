namespace ConsoleWebServer.Framework.RequestProcessors
{
    using System.Net;

    public class NotImplementedRequestProcessor : RequestProcessor, IRequestProcessor
    {
        private const string RequestCannotBeHandledExceptionMessage = "Request cannot be handled.";

        public override IRequestProcessor NextProcessor
        {
            get
            {
                return null;
            }
        }

        public override bool CanProcess(HttpRequest request)
        {
            return true;
        }

        protected override void ProcessLogic(HttpRequest request)
        {
            RequestProcessor.Response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotImplemented, RequestCannotBeHandledExceptionMessage);
        }
    }
}