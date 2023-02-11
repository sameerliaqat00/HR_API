using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HR_API.Repository
{
    public class CompanyProfileRepository : Repository<CompanyProfile>, ICompanyProfileRepository
    {
        public CompanyProfileRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
