namespace ConsoleWebServer.Framework.RequestProcessors
{
    using System;

    public abstract class RequestProcessor : IRequestProcessor
    {
        public static HttpResponse Response { get; set; }

        public abstract IRequestProcessor NextProcessor { get; }

        public abstract bool CanProcess(HttpRequest request);

        public void Process(HttpRequest request)
        {
            if (this.CanProcess(request))
            {
                this.ProcessLogic(request);
            }
            else
            {
                if (this.NextProcessor != null)
                {
                    this.NextProcessor.Process(request);
                }
            }
        }

        protected abstract void ProcessLogic(HttpRequest request);
    }
}