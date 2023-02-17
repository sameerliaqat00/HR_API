using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;

namespace HR_API.Repository
{
    public class CountryRepository:Repository<Country>,ICountryRepository
    {
        public CountryRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
