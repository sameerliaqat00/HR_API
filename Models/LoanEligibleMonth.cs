using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class LoanEligibleMonth
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanEligibleMonthId { get; set; }
        public string? LoanEligibleMonths { get; set; }
        public ICollection<CompanyProfile> CompanyProfile { get; set; }
    }
}
