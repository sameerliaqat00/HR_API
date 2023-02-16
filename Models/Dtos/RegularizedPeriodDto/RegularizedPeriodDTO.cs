using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class RegularizedPeriodDTO
    {
        public int RegularizedPeriodId { get; set; }  
        [Required]
        public string? RegularizedPeriods { get; set; }
    }
}
