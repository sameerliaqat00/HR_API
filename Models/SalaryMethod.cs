using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class SalaryMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaryMethodId { get; set; }
        public string? SalaryMethods { get; set; }
        public ICollection<CompanyProfile> CompanyProfile { get; set; }
    }
}
