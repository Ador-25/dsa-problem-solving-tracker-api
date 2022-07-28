using DSA_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using DSA_Tracker.Areas.Identity.Data;
namespace DSA_Tracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Solution> Solutions { get; set; }

        // create user liked solution n-n relation
        // search other user's solutions
        // create user commented on solution n-n relation

    }
}
