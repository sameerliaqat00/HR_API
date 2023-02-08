using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HR_API.Repository
{
    public class CompanyProfileRepository : Repository<CompanyProfile>, ICompanyProfileRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyProfileRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<CompanyProfile> UpdateAsync(CompanyProfile entity)
        {
            _db.CompanyProfiles.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
