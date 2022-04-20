using dsa_problem_solving_api.Data;
using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Controllers
{
    public class GenericPlatFormController:GenericController<Platform>
    {
        public GenericPlatFormController(IGenericData<Platform>  genarelData):base(genarelData){

        }
    }
}