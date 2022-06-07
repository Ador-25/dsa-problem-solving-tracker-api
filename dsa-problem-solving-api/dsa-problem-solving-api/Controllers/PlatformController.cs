using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Data;
using dsa_problem_solving_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace dsa_problem_solving_api.Controllers
{
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformData _platformData;
        
        public PlatformController(IPlatformData platformData)
        {
            _platformData = platformData;

        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetPLatforms()
        {
            return Ok(_platformData.GetAllPlatforms());

        }
        [HttpGet]
        [Route("api/[controller]/{name}")]
        public IActionResult GetPLatform(string name)
        {
            return Ok(_platformData.GetPlatform(name));

        }
        [HttpPost]
        [Route("api/[controller]/addplatform")]
        public IActionResult AddPlatform(Platform platform)
        {
            platform.PlatformId = new Guid();
            return Ok(_platformData.AddPlatform(platform));
        }
        [HttpPut]
        [Route("api/[controller]/editplatform")]
        public IActionResult EditPlatform(Platform platform)
        {
            return Ok(_platformData.EditPlatform(platform.PlatformId, platform));
        }




    }
}
