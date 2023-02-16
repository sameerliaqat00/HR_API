using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class LoanEligibleMonthCreateDTO
    {
        [Required]
        public string? LoanEligibleMonths { get; set; }
    }
}
