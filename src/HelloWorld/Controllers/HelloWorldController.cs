using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly IConfiguration Configuration;

        public HelloWorldController(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            var user = Configuration["User"];
            return $"Hello World {user}!";
        }
    }
}
