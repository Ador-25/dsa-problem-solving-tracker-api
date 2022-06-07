using DSA_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DSA_Tracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Problem> Problems { get; set; }
    }
}
