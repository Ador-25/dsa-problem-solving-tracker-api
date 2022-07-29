using DSA_Tracker.Models;

namespace DSA_Tracker.Data
{
    public interface ISolutionData
    {
        public List<Solution> GetSolutions(Problem problem);
        
        public Solution SolutionDetails(Guid solutionId);

        //consider taking user email/problem id
        public Solution AddSolution(Solution solution);
        public Solution EditSolution(Solution solution);
        public void DeleteSolution(Guid solutionId);

    }
}
