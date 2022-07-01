
using dsa_problem_solving_api.Data;
using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Controllers
{
    public class GenericProblemController:GenericController<Problem>
    {
        public GenericProblemController(IGenericData<Problem>  genarelData):base(genarelData){

        }
    }
}