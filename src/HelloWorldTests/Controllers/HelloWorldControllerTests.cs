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
            //arrange
            string user = Environment.GetEnvironmentVariable("User") ?? "4everAlone";

            var inMemorySettings = new Dictionary<string, string>
            {
                {"User", user}
            };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            var api = new HelloWorldController(configuration);
            
            //act
            var result = api.Get();

            //assert
            Assert.AreEqual(expected: $"Hello World {user}!", actual: result);
        }
    }
}