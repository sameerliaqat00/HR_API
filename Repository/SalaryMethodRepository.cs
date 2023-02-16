using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;

namespace HR_API.Repository
{
    public class SalaryMethodRepository: Repository<SalaryMethod>,ISalaryMethodRepository
    {
        public SalaryMethodRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
