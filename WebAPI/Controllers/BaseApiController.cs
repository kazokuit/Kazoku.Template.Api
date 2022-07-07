using Microsoft.AspNetCore.Mvc;

namespace Kazoku.Template.WebApi.Controllers
{
    /// <summary>
    /// Base API controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        /// <summary>
        /// Base API controller constructor.
        /// </summary>
        public BaseApiController() : base()
        {

        }
    }
}
