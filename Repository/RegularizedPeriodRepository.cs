using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;

namespace HR_API.Repository
{
    public class RegularizedPeriodRepository: Repository<RegularizedPeriod>,IRegularizedPeriodRepository
    {
        public RegularizedPeriodRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
