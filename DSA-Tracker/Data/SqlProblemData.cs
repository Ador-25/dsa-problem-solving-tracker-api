using DSA_Tracker.Models;

namespace DSA_Tracker.Data
{
    public class SqlProblemData : IProblemData
    {
        private ApplicationDbContext _context;
        public SqlProblemData(ApplicationDbContext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public List<Problem> GetAllProblems()
        {
            return _context.Problems.ToList();
        }

        public Problem GetProblem(int id)
        {
            var search=_context.Problems.Find(id);
            return search;
        }

        public int TotalProblems()
        {
            return _context.Problems.Count();
        }

    }
}
