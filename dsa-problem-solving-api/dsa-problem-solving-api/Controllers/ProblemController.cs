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
    public class ProblemController:ControllerBase

    {
        private readonly IProblemData _problemData;

        ProblemController(IProblemData problemData){
            _problemData=problemData;
        }


        [HttpGet]
        public IActionResult GetAllPLatforms()
        {
            return Ok(_problemData.GetAllProblem());

        }

        [HttpGet]
        public IActionResult GetPLatforms([FromBody]Guid problemId)
        {
            return Ok(_problemData.GetProblem(problemId));

        }

        [HttpPost]
        public IActionResult AddProblem([FromBody]Problem problem){
          var a=_problemData.AddProblem(problem);
          return Ok(a);
            
        }


        [HttpPut]
        public IActionResult EditProblem(Guid problemId, Problem Problem){
          var a= _problemData.EditProblem(problemId, Problem);
          return Ok(a);
            
        }

        
    }
}