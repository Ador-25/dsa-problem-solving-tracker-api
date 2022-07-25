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
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Problem> Problems { get; set; }
       
    }
}
