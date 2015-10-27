namespace ConsoleWebServer.Framework
{
    /// <summary>
    ///     Interface for generating a response from text request sent to the server
    /// </summary>
    public interface IResponseProvider
    {
        /// <summary>
        ///     Generates response from text request
        /// </summary>
        /// <param name="requestAsString">Http request in text format</param>
        /// <returns>The generated response</returns>
        HttpResponse GetResponse(string requestAsString);
    }
}