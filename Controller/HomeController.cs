using Microsoft.AspNetCore.Mvc;

namespace ApiChallenge.Controller
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Autorized]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}

