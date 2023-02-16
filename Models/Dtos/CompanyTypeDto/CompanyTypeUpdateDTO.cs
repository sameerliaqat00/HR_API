using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CompanyTypeUpdateDTO
    {
        public int CompanyTypeId { get; set; }
        [Required]
        public string? CompanyName { get; set; }
    }
}
