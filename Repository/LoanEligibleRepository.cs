using HR_API.Data;
using HR_API.Models;
using HR_API.Repository.IRepository;

namespace HR_API.Repository
{
    public class LoanEligibleRepository:Repository<LoanEligibleMonth>,ILoanEligibleMonthRepository
    {
        public LoanEligibleRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
