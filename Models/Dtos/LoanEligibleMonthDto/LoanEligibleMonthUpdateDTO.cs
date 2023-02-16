using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class LoanEligibleMonthUpdateDTO
    {        
        public int LoanEligibleMonthId { get; set; }
        [Required]
        public string? LoanEligibleMonths { get; set; }
    }
}
