namespace ConsoleWebServer.Tests
{
    using Application;
    using Framework;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ApiControllerReturnMeTests
    {
        [TestMethod]
        public void TestIfReturnMeReturnsParamWithValueAsJson()
        {
            var request = new HttpRequest("GET", "Api/ReturnMe/test", "2.0");
            var apiController = new ApiController(request);

            var result = apiController.ReturnMe("test");

            Assert.AreEqual("{\"param\":\"test\"}", result.GetResponse().Body);
        }
    }
}