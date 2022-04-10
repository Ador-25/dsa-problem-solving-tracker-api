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



    }
}
