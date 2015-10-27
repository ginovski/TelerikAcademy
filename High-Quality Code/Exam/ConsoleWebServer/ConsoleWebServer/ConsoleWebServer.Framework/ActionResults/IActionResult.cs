namespace ConsoleWebServer.Framework.ActionResults
{
    /// <summary>
    ///     Provides HttpResponse contract
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        ///     Creates the response with the needed information for it and returns it
        /// </summary>
        /// <returns>The created response</returns>
        HttpResponse GetResponse();
    }
}