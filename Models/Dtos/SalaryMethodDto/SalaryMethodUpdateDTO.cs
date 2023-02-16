using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class SalaryMethodUpdateDTO
    {
        public int SalaryMethodId { get; set; }
        [Required]
        public string? SalaryMethods { get; set; }
    }
}
