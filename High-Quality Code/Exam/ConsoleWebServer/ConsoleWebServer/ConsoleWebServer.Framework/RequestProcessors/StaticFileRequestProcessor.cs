namespace ConsoleWebServer.Framework.RequestProcessors
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;

    public class StaticFileRequestProcessor : RequestProcessor, IRequestProcessor
    {
        public override IRequestProcessor NextProcessor
        {
            get
            {
                return new ProtocolVersionRequestProcessor();
            }
        }

        public override bool CanProcess(HttpRequest request)
        {
            return request.Uri.LastIndexOf(".", StringComparison.Ordinal) > request.Uri.LastIndexOf("/", StringComparison.Ordinal);
        }

        protected override void ProcessLogic(HttpRequest request)
        {
            string filePath = Environment.CurrentDirectory + "/" + request.Uri;

            if (!File.Exists(filePath))
            {
                RequestProcessor.Response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, "File not found!");
                return;
            }

            string fileContents = File.ReadAllText(filePath);
            var response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, fileContents);
            RequestProcessor.Response = response;
        }
    }
}