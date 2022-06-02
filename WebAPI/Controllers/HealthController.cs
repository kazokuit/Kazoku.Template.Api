using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Health controller.
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        /// <summary>
        /// Health controller constructor.
        /// </summary>
        /// <param name="logger"></param>
        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Health check endpoint.
        /// </summary>
        /// <returns>Status code 200.</returns>
        [HttpGet]
        public ActionResult GetHealth()
        {
            _logger.LogInformation("Server is responding.");
            return Ok();
        }
    }
}
