using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;

namespace HR_API.Repository
{
    public class WorkLocationRepository : Repository<WorkLocation>, IWorkLocationRepository
    {
        public WorkLocationRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
