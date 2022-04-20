using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Data;
using dsa_problem_solving_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace dsa_problem_solving_api.Controllers
{
    public class GenericController<T>:ControllerBase   where T :class
    {
        private readonly IGenericData<T> _genericdata;
        
        public GenericController(IGenericData<T> genericData)
        {
            _genericdata = genericData;

        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_genericdata.GetAll());

        }

        [HttpGet]
        public IActionResult Get([FromBody]Guid Id)
        {
            return Ok(_genericdata.Get(Id));

        }

        [HttpPost]
        public IActionResult Add([FromBody]T platform){
          var a=_genericdata.Add(platform);
          return Ok(a);
            
        }


        [HttpPut]
        public IActionResult Edit(Guid Id, T platform){
          var a= _genericdata.Edit(Id, platform);
          return Ok(a);
            
        }
    }
}