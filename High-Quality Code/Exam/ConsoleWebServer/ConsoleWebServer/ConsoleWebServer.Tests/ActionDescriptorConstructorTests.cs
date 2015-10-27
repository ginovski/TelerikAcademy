namespace ConsoleWebServer.Tests
{
    using Framework;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ActionDescriptorConstructorTests
    {
        [TestMethod]
        public void EmptyUriShouldGoToHomeControllerIndex()
        {
            var actionDescriptor = new ActionDescriptor(null);

            Assert.AreEqual("Home", actionDescriptor.ControllerName);
            Assert.AreEqual("Index", actionDescriptor.ActionName);
            Assert.AreEqual("Param", actionDescriptor.Parameter);
        }

        [TestMethod]
        public void IfControllerNameIsProvidedItShouldBeSetAsControllerNameTheRestShouldBeDefault()
        {
            var controllerName = "Test";
            var actionDescriptor = new ActionDescriptor(controllerName);

            Assert.AreEqual(controllerName, actionDescriptor.ControllerName);
            Assert.AreEqual("Index", actionDescriptor.ActionName);
            Assert.AreEqual("Param", actionDescriptor.Parameter);
        }

        [TestMethod]
        public void IfControllerNameAndActionAreProvidedTheyShouldBeSetParamShouldBeDefault()
        {
            var controllerName = "Test";
            var actionName = "Test1";
            var actionDescriptor = new ActionDescriptor(controllerName + "/" + actionName);

            Assert.AreEqual(controllerName, actionDescriptor.ControllerName);
            Assert.AreEqual(actionName, actionDescriptor.ActionName);
            Assert.AreEqual("Param", actionDescriptor.Parameter);
        }

        [TestMethod]
        public void IfUriIsFullItShouldBeSetted()
        {
            var controllerName = "Test";
            var actionName = "Test1";
            var paramName = "1";
            var actionDescriptor = new ActionDescriptor(controllerName + "/" + actionName + "/" + paramName);

            Assert.AreEqual(controllerName, actionDescriptor.ControllerName);
            Assert.AreEqual(actionName, actionDescriptor.ActionName);
            Assert.AreEqual(paramName, actionDescriptor.Parameter);
        }
    }
}