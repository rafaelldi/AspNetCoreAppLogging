using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreAppLogging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            _logger.LogInformation($"Id = {id}");
            return "value";
        }
    }
}
