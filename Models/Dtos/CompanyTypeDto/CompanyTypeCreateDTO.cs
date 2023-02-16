using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CompanyTypeCreateDTO
    {
        [Required]
        public string? CompanyName { get; set; }
    }
}
