using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class CompanyType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyTypeId { get; set; }
        public string? CompanyName { get; set; }
        public ICollection<CompanyProfile> CompanyProfile { get; set; }
    }
}
