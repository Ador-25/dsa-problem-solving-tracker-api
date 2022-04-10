using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Data
{
    public interface IPlatformData
    {
        List<Platform> GetAllPlatforms();
        Platform AddPlatform(Platform platform);
        Platform GetPlatform(string platformName);
        Platform EditPlatform(Guid platformId,Platform platform);
    }
}
