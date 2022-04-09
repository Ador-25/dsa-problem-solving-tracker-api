using dsa_problem_solving_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dsa_problem_solving_api.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Platform> Platforms { get; set; }
    }
}
