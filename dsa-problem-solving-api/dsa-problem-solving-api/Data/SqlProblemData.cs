using dsa_problem_solving_api.Models;
using dsa_problem_solving_api.Contexts;


namespace dsa_problem_solving_api.Data
{
    public class SqlProblemData:IProblemData
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SqlProblemData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

         public Problem GetProblem(Guid Id){
            return _applicationDbContext.Problems.SingleOrDefault(x => x.ProblemId == Id);

         }
        public List<Problem> GetAllProblem(){
            return _applicationDbContext.Problems.ToList();
        }
        public Problem AddProblem(Problem  problem){
            problem.ProblemId=Guid.NewGuid();
             _applicationDbContext.Problems.Add(problem);
            return problem;
        }
        public Problem EditProblem(Guid Id,Problem problem){
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