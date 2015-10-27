namespace ConsoleWebServer.Framework.RequestProcessors
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;

    public class ProtocolVersionRequestProcessor : RequestProcessor, IRequestProcessor
    {
        private const string ControllerNotFoundMessageFormat = "Controller with name {0} not found!";

        public override IRequestProcessor NextProcessor
        {
            get
            {
                return new NotImplementedRequestProcessor();
            }
        }

        public override bool CanProcess(HttpRequest request)
        {
            return request.ProtocolVersion.Major < 3;
        }

        protected override void ProcessLogic(HttpRequest request)
        {
            HttpResponse response;
            try
            {
                var controller = this.CreateController(request);
                var actionInvoker = new NewActionInvoker();
                var actionResult = actionInvoker.InvokeAction(controller, request.Action);
                response = actionResult.GetResponse();
            }
            catch (HttpNotFound exception)
            {
                response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, exception.Message);
            }
            catch (Exception exception)
            {
                response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.InternalServerError, exception.Message);
            }

            RequestProcessor.Response = response;
        }

        // TODO: Extract in different class
        private Controller CreateController(HttpRequest request)
        {
            var controllerClassName = request.Action.ControllerName + "Controller";
            var type = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == controllerClassName.ToLower() && typeof(Controller).IsAssignableFrom(x));
            if (type == null)
            {
                throw new HttpNotFound(
                    string.Format(ControllerNotFoundMessageFormat, controllerClassName));
            }

            var instance = (Controller)Activator.CreateInstance(type, request);
            return instance;
        }
    }
}