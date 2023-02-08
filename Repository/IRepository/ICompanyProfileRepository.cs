using HR_API.Models;
using System.Linq.Expressions;

namespace HR_API.Repository.IRepository
{
    public interface ICompanyProfileRepository
    {
        Task<List<CompanyProfile>> GetAllAsync(Expression<Func<CompanyProfile, bool>> filter = null);
        Task<CompanyProfile> GetAsync(Expression<Func<CompanyProfile, bool>> filter = null,bool tracked = true);
        Task CreateAsync(CompanyProfile entity);
        Task UpdateAsync(CompanyProfile entity);
        Task RemoveAsync(CompanyProfile entity);
        Task SaveAsync();
    }
}
