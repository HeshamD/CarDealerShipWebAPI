using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarDealerShipWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //Home 

        [HttpGet]
        [Route("/")]
        public IActionResult Home()
        {
            return StatusCode(200);
        }

    }
}
