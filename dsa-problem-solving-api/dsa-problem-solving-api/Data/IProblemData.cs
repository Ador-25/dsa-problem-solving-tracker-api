using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Data
{
    public interface IProblemData
    {
        Problem GetProblem(Guid Id);
        List<Problem> GetAllProblem();
        Problem AddProblem(Problem  problem);
        Problem EditProblem(Guid Id,Problem problem);

    }
}