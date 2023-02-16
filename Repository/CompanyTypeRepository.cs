using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;

namespace HR_API.Repository
{
    public class CompanyTypeRepository : Repository<CompanyType>,ICompanyTypeRepository
    {
        public CompanyTypeRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
