namespace ConsoleWebServer.Framework
{
    using System;
    using System.Linq;

    public class ActionDescriptor
    {
        private const string DefaultControllerName = "Home";
        private const string DefaultMethodName = "Index";
        private const string DefaultParameter = "Param";
        private const string UriStringFormat = "/{0}/{1}/{2}";

        public ActionDescriptor(string uri)
        {
            uri = uri ?? string.Empty;

            var uriParts = uri.Split(new[] { '/', '/', '/', '/', '/' }, StringSplitOptions.RemoveEmptyEntries);

            this.ControllerName = uriParts.Length >
                0 ?
                uriParts[0]
                : DefaultControllerName;

            this.ActionName = uriParts.Length >
                1 ?
                uriParts[1]
                : DefaultMethodName;

            this.Parameter = uriParts.Length >
                2 ?
                uriParts[2]
                : DefaultParameter;
        }

        public string ActionName { get; private set; }

        public string ControllerName { get; private set; }

        public string Parameter { get; private set; }

        public override string ToString()
        {
            return string.Format(UriStringFormat, this.ControllerName, this.ActionName, this.Parameter);
        }
    }
}