using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSA_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //endpoint: http://localhost:5207/api/test/strings
        [HttpGet("strings")]
        public IActionResult TestMethod()
        {
            return Ok(new string[]{ 
            "23", "24"});
        }
    }
}
