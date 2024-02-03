using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace HelloWorld.Controllers.Tests
{
    [TestFixture()]
    public class HelloWorldControllerTests
    {
        [Test()]
        public void GetHelloWorld()
        {
            var user = Environment.GetEnvironmentVariable("User");

            var inMemorySettings = new Dictionary<string, string> 
            {
                {"User", user}
            };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            var api = new HelloWorldController(configuration);
            var result = api.Get();

            Assert.AreEqual(expected: $"Hello World!", actual: result, message: $"{user} y {result}");
        }
    }
}