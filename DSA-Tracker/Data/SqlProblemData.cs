using DSA_Tracker.Areas.Identity.Data;
using DSA_Tracker.Models;

namespace DSA_Tracker.Data
{
    public class SqlProblemData : IProblemData
    {
        private IdentityDbContext _context;
        public SqlProblemData(IdentityDbContext context)
        {
            _context = context;
        }

      
        public DifficultyCounterHelper DifficultyPerProblemHelper(string email)
        {
            throw new NotImplementedException();
        }

        public List<Problem> GetAllProblems(string email)
        {
            return _context
                .Problems
                .Where(us=>us.ApplicationUser.Email==email)
                .ToList();
        }

        public Problem GetProblem(int id)
        {
            var search=_context.Problems.Find(id);
            return search;
        }

        public PlatformCountHelper ProblemsPerPlatform(string email)
        {
            throw new NotImplementedException();
        }

        public TagCounterHelper ProblemTags(string email)
        {
            throw new NotImplementedException();
        }

        public string[] Tags(string email)
        {
            throw new NotImplementedException();
        }

        public int TotalProblems()
        {
            return _context.Problems.Count();
        }

    }
}
