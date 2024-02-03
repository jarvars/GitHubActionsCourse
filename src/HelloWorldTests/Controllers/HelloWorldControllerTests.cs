using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace HelloWorld.Controllers.Tests
{
    [TestFixture()]
    public class HelloWorldControllerTests
    {
        [Test()]
        public void GetTest()
        {
            var user = Environment.GetEnvironmentVariable("User");

            var configuration = new Mock<IConfiguration>();
            configuration
                .SetupGet(m => m["User"])
                .Returns(user);

            var api = new HelloWorldController(configuration.Object);
            var result = api.Get();

            Assert.That(result, Is.EqualTo($"Hello World {user}!"));
        }
    }
}