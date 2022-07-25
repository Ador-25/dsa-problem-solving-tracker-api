namespace DSA_Tracker.Data
{
    public class SqlEndPoint : IEndpoint
    {
        private ApplicationDbContext _applicationDbContext;
        public SqlEndPoint(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public int TotalNumberOfProblems()
        {
            return _applicationDbContext.Problems.Count();
        }
    }
}
