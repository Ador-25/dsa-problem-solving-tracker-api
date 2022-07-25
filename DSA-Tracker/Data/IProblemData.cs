using DSA_Tracker.Models;

namespace DSA_Tracker.Data
{
    public interface IProblemData
    {
        public List<Problem> GetAllProblems();
        public Problem GetProblem(int id);
        public int TotalProblems();

    }
}