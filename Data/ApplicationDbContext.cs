using HR_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
    }
}
