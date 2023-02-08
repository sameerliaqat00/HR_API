using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HR_API.Repository
{
    public class CompanyProfileRepository : ICompanyProfileRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyProfileRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task CreateAsync(CompanyProfile entity)
        {
            await _db.CompanyProfiles.AddAsync(entity);
            await SaveAsync();
        }

        public async Task<CompanyProfile> GetAsync(Expression<Func<CompanyProfile, bool>> filter = null, bool tracked = true)
        {
            IQueryable<CompanyProfile> companyProfiles = _db.CompanyProfiles;
            if (!tracked)
            {
                companyProfiles = companyProfiles.AsNoTracking();
            }
            if (filter != null)
            {
                companyProfiles = companyProfiles.Where(filter);
            }
            return await companyProfiles.FirstOrDefaultAsync();
        }

        public async Task<List<CompanyProfile>> GetAllAsync(Expression<Func<CompanyProfile, bool>> filter = null)
        {
            IQueryable<CompanyProfile> companyProfiles = _db.CompanyProfiles;
            if (filter != null)
            {
                companyProfiles = companyProfiles.Where(filter);
            }
            return await companyProfiles.ToListAsync();
        }

        public async Task RemoveAsync(CompanyProfile entity)
        {
            _db.CompanyProfiles.Remove(entity);
            await SaveAsync();
        }
        public async Task UpdateAsync(CompanyProfile entity)
        {
            _db.CompanyProfiles.Update(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
