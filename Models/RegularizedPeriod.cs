using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class RegularizedPeriod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegularizedPeriodId { get; set; }
        public string? RegularizedPeriods { get; set; }
        public ICollection<CompanyProfile> CompanyProfile { get; set; }
    }
}
