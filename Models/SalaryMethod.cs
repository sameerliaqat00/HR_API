using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class SalaryMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalayMethodId { get; set; }
        public string? SalayMethod { get; set; }
        public ICollection<CompanyProfile> CompanyProfile { get; set; }
    }
}
