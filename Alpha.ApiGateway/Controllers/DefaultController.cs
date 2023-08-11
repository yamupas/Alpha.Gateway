using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alpha.ApiGateway.Controllers
{
    [Route("/")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DefaultController : ControllerBase
    {
        public DefaultController()
        {

        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Running");
        }
    }
}
