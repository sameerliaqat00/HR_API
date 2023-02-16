using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class SalaryMethodCreateDTO
    {
        [Required]
        public string? SalaryMethods { get; set; }
    }
}
