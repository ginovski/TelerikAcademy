namespace ConsoleWebServer.Framework.RequestProcessors
{
    public interface IRequestProcessor
    {
        IRequestProcessor NextProcessor { get; }

        bool CanProcess(HttpRequest request);

        void Process(HttpRequest request);
    }
}