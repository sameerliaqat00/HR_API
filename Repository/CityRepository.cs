using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;

namespace HR_API.Repository
{
    public class CityRepository:Repository<City>,ICityRepository
    {
        public CityRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
