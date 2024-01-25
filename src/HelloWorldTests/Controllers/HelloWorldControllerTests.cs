using NUnit.Framework;

namespace HelloWorld.Controllers.Tests
{
    [TestFixture()]
    public class HelloWorldControllerTests
    {
        [Test()]
        public void GetTest()
        {
            var api = new HelloWorldController();
            var result = api.Get();

            Assert.That(result, Is.EqualTo("Hello World"));
        }
    }
}