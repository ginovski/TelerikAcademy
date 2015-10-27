namespace ConsoleWebServer.Framework
{
    using System;
    using System.Net;
    using RequestProcessors;

    public class ResponseProvider : IResponseProvider
    {
        public HttpResponse GetResponse(string requestAsString)
        {
            RequestProcessor requestProcessor = new HeadRequestProcessor();
            HttpRequest request;
            try
            {
                var requestParser = new HttpRequest("GET", "/", "1.1");
                request = requestParser.Parse(requestAsString);
            }
            catch (Exception ex)
            {
                return new HttpResponse(new Version(1, 1), HttpStatusCode.BadRequest, ex.Message);
            }

            requestProcessor.Process(request);
            var response = RequestProcessor.Response;

            return response;
        }
    }
}