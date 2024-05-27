using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIPracticeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;

        }

        [HttpGet]

        public IActionResult GetStudents()
        {
            _logger.LogInformation("Executed Logger");
            _logger.LogTrace("Logged Trace");
            _logger.LogDebug("Logged Debug");
            _logger.LogError("Logged Error");
            _logger.LogCritical("Logged Critical");
            return Ok();

        }
    }
}
