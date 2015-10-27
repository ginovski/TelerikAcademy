﻿namespace ConsoleWebServer.Framework
{
    using ActionResults;

    internal class NewActionInvoker
    {
        public IActionResult InvokeAction(Controller controller, ActionDescriptor actionDescriptor)
        {
            return new ActionInvoker().InvokeAction(controller, actionDescriptor);
        }
    }
}