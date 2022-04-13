using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Data;
using dsa_problem_solving_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace dsa_problem_solving_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PlatformController : ControllerBase
    {
        private readonly IPlatformData _platformData;
        
        public PlatformController(IPlatformData platformData)
        {
            _platformData = platformData;

        }
        
        [HttpGet]
        public IActionResult GetAllPLatforms()
        {
            return Ok(_platformData.GetAllPlatforms());

        }

        [HttpGet]
        public IActionResult GetPLatforms([FromBody]string platformName)
        {
            return Ok(_platformData.GetPlatform(platformName));

        }

        [HttpPost]
        public IActionResult AddPlatform([FromBody]Platform platform){
          var a=_platformData.AddPlatform(platform);
          return Ok(a);
            
        }


        [HttpPut]
        public IActionResult EditPlatForm(Guid platformId, Platform platform){
          var a= _platformData.EditPlatform(platformId, platform);
          return Ok(a);
            
        }



    }
}
