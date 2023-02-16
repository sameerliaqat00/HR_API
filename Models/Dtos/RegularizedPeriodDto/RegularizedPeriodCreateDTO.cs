using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class RegularizedPeriodCreateDTO
    {
        [Required]
        public string? RegularizedPeriods { get; set; }
    }
}
