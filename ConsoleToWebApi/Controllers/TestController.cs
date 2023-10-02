using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "hello form GET";
        }
        public string Get1()
        {
            return "hello from get1";
        }
    }
}
