using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Models;


namespace dsa_problem_solving_api.Data
{
    public class SqlGenericProblemData:IGenericData<Problem>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SqlGenericProblemData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

         public Problem Get(Guid Id){
            return _applicationDbContext.Problems.SingleOrDefault(x => x.ProblemId == Id);

         }
        public List<Problem> GetAll(){
            return _applicationDbContext.Problems.ToList();
        }
        public Problem Add(Problem  problem){
            problem.ProblemId=Guid.NewGuid();
             _applicationDbContext.Problems.Add(problem);
            return problem;
        }
        public Problem Edit(Guid Id,Problem problem){
             var temp = _applicationDbContext.Problems.SingleOrDefault(x => x.ProblemId == Id);
            if(temp == null)
            {
                return null;
            }
            else
            {
                temp = problem;
            }

            return temp;
        }
    }
}