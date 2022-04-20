using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Data
{
    public class SqlGenericPlatformData:IGenericData<Platform>
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public SqlGenericPlatformData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Platform Add(Platform platform)
        {
            platform.PlatformId=Guid.NewGuid();
             _applicationDbContext.Platforms.Add(platform);
            return platform;
        }

        public Platform Edit(Guid platformId, Platform platform)
        {
          var temp = _applicationDbContext.Platforms.SingleOrDefault(x => x.PlatformId == platformId);
            if(temp == null)
            {
                return null;
            }
            else
            {
                temp = platform;
            }

            return temp;
        }

        public List<Platform> GetAll()
        {
            return _applicationDbContext.Platforms.ToList();
        }

        public Platform Get(Guid Id)
        {
        return _applicationDbContext.Platforms.SingleOrDefault(x => x.PlatformId == Id);

        }
    }
}