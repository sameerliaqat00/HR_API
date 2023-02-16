using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class RegularizedPeriodUpdateDTO
    {      
        public int RegularizedPeriodId { get; set; }  
        [Required]
        public string? RegularizedPeriods { get; set; }
    }
}
