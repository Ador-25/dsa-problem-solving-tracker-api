using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Data
{
    public class SqlPlatformData : IPlatformData
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public SqlPlatformData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Platform AddPlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public Platform EditPlatform(Guid platformId, Platform platform)
        {
            throw new NotImplementedException();
        }

        public List<Platform> GetAllPlatforms()
        {
            return _applicationDbContext.Platforms.ToList();
        }

        public Platform GetPlatform(string platformName)
        {
            throw new NotImplementedException();
        }
    }
}
